using UnityEngine;

public class P1CloneController : MonoBehaviour
{
    public Spawner spawner;
    public Boomer1 boomer1;
    public ParticleSystem CrystallizeDashEffect;
    public static bool isCrystallize = false, isDashing = false, useSkill = false;
    private Rigidbody rb;
    public static int speed = 25;
    private Vector3 currentVelocity, targetVelocity;
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        speed = Player1Controller.speed;
    }
    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            if (rb.velocity.x < -5)
            {
                currentVelocity = rb.velocity;
                targetVelocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                rb.velocity = Vector3.Lerp(currentVelocity, targetVelocity, 0.1f);
            }
            rb.AddForce(new Vector3(speed, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (rb.velocity.x > 5)
            {
                currentVelocity = rb.velocity;
                targetVelocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                rb.velocity = Vector3.Lerp(currentVelocity, targetVelocity, 0.1f);
            }
            rb.AddForce(new Vector3(-speed, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (rb.velocity.z < -5)
            {
                currentVelocity = rb.velocity;
                targetVelocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
                rb.velocity = Vector3.Lerp(currentVelocity, targetVelocity, 0.1f);
            }
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (rb.velocity.z > 5)
            {
                currentVelocity = rb.velocity;
                targetVelocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
                rb.velocity = Vector3.Lerp(currentVelocity, targetVelocity, 0.1f);
            }
            rb.AddForce(new Vector3(0, 0, -speed));
        }

    }

    void Update()
    {
        if (useSkill && isCrystallize)
        {
            isDashing = true;
            CrystallizeDashEffect.Play();
            Invoke("ResetisDashing", 1.2f);
        }
    }
    private void OnCollisionEnter(Collision obj)
    {
        if (isDashing && (obj.gameObject.CompareTag("P2") || obj.gameObject.CompareTag("C2")))
        {
            boomer1.DestroyP2(obj, this.transform.position);

            Destroy(GameObject.FindGameObjectWithTag("trash"), 12);
        }
    }
    private void ResetisDashing()
    {
        isDashing = false;
        CrystallizeDashEffect.Stop();
    }
}
