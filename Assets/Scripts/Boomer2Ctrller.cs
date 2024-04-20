using UnityEngine;
using UnityEngine.AI;

public class Boomer2Ctrller : MonoBehaviour
{
    private float shakeAmount = 0.015f;
    private float shakeSpeed = 100;
    public static bool isMoving = false, isC1Inside = false, isAggressive = false;
    public GameObject ball, barrier;
    public NavMeshAgent Boomer;
    public Transform Player1, Player1Clone, self;
    private void Update()
    {
        if (isAggressive && ball.activeSelf && barrier.activeSelf)
        {
            float newX = Boomer.transform.position.x + Mathf.Sin(Time.time * shakeSpeed) * shakeAmount;
            float newZ = Boomer.transform.position.z + Mathf.Sin(Time.time * shakeSpeed) * shakeAmount;
            Boomer.transform.position = new Vector3(newX, Boomer.transform.position.y, newZ);
        }
    }
    private void OnTriggerStay(Collider obj)
    {
        if (ball.activeSelf && barrier.activeSelf)
        {
            isMoving = true;
            if (obj.CompareTag("C1"))
            {
                isC1Inside = true;
                Boomer.SetDestination(Player1Clone.position);
            }
            else if (obj.CompareTag("P1"))
            {
                if (isC1Inside)
                {
                    Boomer.SetDestination(Player1Clone.position);
                }
                else
                {
                    Boomer.SetDestination(Player1.position);
                }
            }
        }
        else if (isMoving)
        {
            isMoving = false;
            Boomer.SetDestination(self.position);
        }
    }
    private void OnTriggerExit(Collider obj)
    {
        if ((obj.CompareTag("P1") || obj.CompareTag("C1")) && barrier.activeSelf)
        {
            isMoving = false;
            Boomer.SetDestination(self.position);
        }
        if (obj.CompareTag("C1"))
        {
            isC1Inside = false;
        }
    }
}
