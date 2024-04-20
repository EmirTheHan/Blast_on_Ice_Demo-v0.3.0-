using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Erase_Token : MonoBehaviour
{
    private float cd;
    public AudioSource tokenSound;
    public GameObject tokenBoom, P1, P2, Barrier1, Barrier2, P1Clone, P2Clone;
    public Image P1CooldownImage, P2CooldownImage;
    private float totalRotation = 0f;
    Renderer _renderer;
    Collider _collider;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _collider = GetComponent<Collider>();
    }
    void Update()
    {
        if (_renderer.enabled)
        {
            if (totalRotation < 360f)
            {
                transform.Rotate(Vector3.right, 60 * Time.deltaTime);
                totalRotation += 60 * Time.deltaTime;
            }
            else
            {
                transform.Rotate(Vector3.forward, 60 * Time.deltaTime);
                totalRotation += 60 * Time.deltaTime;
                if (totalRotation > 720)
                    totalRotation = 0;
            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("B") && BallManager.owner != 0)
        {
            if (BallManager.owner == 1 && (P1.activeSelf || P1Clone.activeSelf))
            {
                Barrier2.SetActive(false);
                StartCoroutine(ResetP1());
            }
            else if (BallManager.owner == 2 && (P2.activeSelf || P2Clone.activeSelf))
            {
                Barrier1.SetActive(false);
                StartCoroutine(ResetP2());
            }

            tokenSound.pitch = Random.Range(0.3f, .6f);
            gameObject.GetComponent<AudioSource>().Play();

            Instantiate(tokenBoom, transform.position, transform.rotation);

            DeactivateToken();
        }
    }
    IEnumerator ResetP1()
    {
        P1CooldownImage.fillAmount = 1;
        cd = 20;
        while (P1.activeSelf && !EndGame.Gameover)
        {
            cd -= Time.deltaTime;
            P1CooldownImage.fillAmount = cd / 20;
            if (cd <= 0)
            {
                Barrier2.SetActive(true);
                break;
            }
            yield return null;
        }
    }
    IEnumerator ResetP2()
    {
        P2CooldownImage.fillAmount = 1;
        cd = 20;
        while (P2.activeSelf && !EndGame.Gameover)
        {
            cd -= Time.deltaTime;
            P2CooldownImage.fillAmount = cd / 20;
            if (cd <= 0)
            {
                Barrier1.SetActive(true);
                break;
            }
            yield return null;
        }
    }
    public void ActivateToken()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Renderer>().enabled = true;
        }
        _renderer.enabled = true;
        _collider.enabled = true;
    }
    public void DeactivateToken()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Renderer>().enabled = false;
        }
        _renderer.enabled = false;
        _collider.enabled = false;
    }
}

