using UnityEngine;

public class WallSound : MonoBehaviour
{
    public AudioSource d;
    private float speed;
    private void OnCollisionEnter(Collision obj)
    {
        speed = obj.rigidbody.velocity.magnitude;
        if (speed >= 2f)
        {
            d.volume = .05f * speed;
            d.Play();
        }
    }
}
