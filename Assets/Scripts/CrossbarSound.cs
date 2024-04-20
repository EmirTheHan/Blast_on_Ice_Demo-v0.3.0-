using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbarSound : MonoBehaviour
{
    public AudioSource direksesi;
    public float hız;
    private void OnCollisionEnter(Collision obj)
    {
        direksesi.Play();
        if (hız >= 4f)
        {
            direksesi.volume = .2f * hız;
            direksesi.pitch = .7f / direksesi.volume;
            direksesi.Play();
        }
        else if (hız >= 2f)
        {
            direksesi.volume = .2f * hız;
            direksesi.pitch = .55f / direksesi.volume;
            direksesi.Play();
        }

    }
}
