using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound : MonoBehaviour
{
    public Rigidbody rb;
    public AudioSource IS;
    private float speed, selfSpeed;
    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("P2"))
        {
            speed = obj.rigidbody.velocity.magnitude;
            selfSpeed = rb.velocity.magnitude;
            if (speed >= 2f || selfSpeed >= 2f)
            {
                IS.volume = .05f * speed;
                IS.Play();
            }
        }
    }
}
