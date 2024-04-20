using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHitSound : MonoBehaviour
{
    public AudioSource b;
    float speed;
    private void OnCollisionEnter(Collision obj)
    {
        speed = obj.rigidbody.velocity.y;
        if (speed > 1f)
        {
            b.volume = .3f * speed;
            b.Play();
        }       
    }
}
