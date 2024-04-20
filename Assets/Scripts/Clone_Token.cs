using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Clone_Token : MonoBehaviour
{
    private float cd;
    public AudioSource tokenSound;
    public GameObject tokenBoom, P1, P2, Player1Clone, Player2Clone, P1CloneBody, P2CloneBody;
    public Image P1CooldownImage, P2CooldownImage;
    public Material Barrier1Material, Barrier2Material;
    private float totalRotation = 0f;
    Renderer _renderer;
    Collider _collider;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _collider = GetComponent<Collider>();
    }
    private void Update()
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
            if (BallManager.owner == 1 && (P1.activeSelf || Player1Clone.activeSelf))
            {
                if (Player1Controller.isCrystallize)
                {
                    P1CloneBody.GetComponent<Renderer>().material = Barrier1Material;
                }
                Player1Clone.transform.position=transform.position;
                Player1Clone.SetActive(true);
                StartCoroutine(ResetP1());
            }
            else if (BallManager.owner == 2 && (P2.activeSelf || Player2Clone.activeSelf))
            {
                if (Player2Controller.isCrystallize)
                {
                    P2CloneBody.GetComponent<Renderer>().material = Barrier2Material;
                }
                Player2Clone.transform.position = transform.position;
                Player2Clone.SetActive(true);
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
        cd = 25;
        while (Player1Clone.activeSelf && !EndGame.Gameover)
        {
            cd -= Time.deltaTime;
            P1CooldownImage.fillAmount = cd / 25;
            if (cd <= 0)
            {
                Player1Clone.SetActive(false);
                Player1Clone.GetComponent<Rigidbody>().Sleep();
                break;
            }
            yield return null;
        }
    }
    IEnumerator ResetP2()
    {
        P2CooldownImage.fillAmount = 1;
        cd = 25;
        while (Player2Clone.activeSelf && !EndGame.Gameover)
        {
            cd -= Time.deltaTime;
            P2CooldownImage.fillAmount = cd / 25;
            if (cd <= 0)
            {
                Player2Clone.SetActive(false);
                Player2Clone.GetComponent<Rigidbody>().Sleep();
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
