using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Crystallize_Token : MonoBehaviour
{
    private float cd;
    public AudioSource tokenSound;
    public GameObject tokenBoom, P1, P2, P1Body, P2Body, P1CloneBody, P2CloneBody, P1Clone, P2Clone;
    public Image P1CooldownImage, P2CooldownImage;
    public Material Player1Material, Barrier1Material, Player2Material, Barrier2Material;
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
            if (BallManager.owner == 1 && (P1.activeSelf || P1Clone.activeSelf))
            {
                Player1Controller.isCrystallize = true;
                P1CloneController.isCrystallize = true;
                P1Body.GetComponent<Renderer>().material = Barrier1Material;
                P1CloneBody.GetComponent<Renderer>().material = Barrier1Material;
                StartCoroutine(ResetP1());
            }
            else if (BallManager.owner == 2 && (P2.activeSelf || P2Clone.activeSelf))
            {
                Player2Controller.isCrystallize = true;
                P2CloneController.isCrystallize = true;
                P2Body.GetComponent<Renderer>().material = Barrier2Material;
                P2CloneBody.GetComponent<Renderer>().material = Barrier2Material;
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
        while (P1.activeSelf && !EndGame.Gameover)
        {
            cd -= Time.deltaTime;
            P1CooldownImage.fillAmount = cd / 25;
            if (cd <= 0)
            {
                Player1Controller.isDashing = false;
                P1CloneController.isDashing = false;
                Player1Controller.isCrystallize = false;
                P1CloneController.isCrystallize = false;
                P1Body.GetComponent<Renderer>().material = Player1Material;
                P1CloneBody.GetComponent<Renderer>().material = Player1Material;
                break;
            }
            yield return null;
        }
    }
    IEnumerator ResetP2()
    {
        P2CooldownImage.fillAmount = 1;
        cd = 25;
        while (P2.activeSelf && !EndGame.Gameover)
        {
            cd -= Time.deltaTime;
            P2CooldownImage.fillAmount = cd / 25;
            if (cd <= 0)
            {
                Player2Controller.isDashing = false;
                P2CloneController.isDashing = false;
                Player2Controller.isCrystallize = false;
                P2CloneController.isCrystallize = false;
                P2Body.GetComponent<Renderer>().material = Player2Material;
                P2CloneBody.GetComponent<Renderer>().material = Player2Material;
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
