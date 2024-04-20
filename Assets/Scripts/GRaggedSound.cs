using UnityEngine;

public class GRaggedSound : MonoBehaviour
{

    public Rigidbody rb;
    public AudioSource b;
    private float speed;
    private void Update()
    {
        speed = rb.velocity.magnitude;
        if (gameObject.transform.position.y <= .45 && speed >= 15f)
        {
            b.volume = .05f * speed;
        }
        else
        {
            b.volume = 0;
        }
    }
}
