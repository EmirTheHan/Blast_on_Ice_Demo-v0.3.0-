using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.AI;

public class Player2Controller : MonoBehaviour
{
    public NavMeshAgent barrier2;
    public Spawner spawner;
    public Boomer2 boomer2;
    public ParticleSystem CrystallizeDashEffect;
    public Material P2Material;
    public GameObject body, barrier1, P2_Clone;
    public static bool p2skill, isCrystallize = false, isDashing = false;
    public Image skillImage;
    public static float cd, cdTime = 10f;
    private Rigidbody rb;
    public AudioSource sound, dashS;
    public static int skillSpeed, speed = 25;
    private Vector3 currentVelocity, targetVelocity;
    private void Start()
    {
        skillSpeed = speed * 75;
    }
    private void OnEnable()
    {
        ResetTokenEffects();
        skillImage.fillAmount = 1;
        rb = GetComponent<Rigidbody>();
        p2skill = true;
    }
    private void FixedUpdate()
    {
        if (StartTimer.isStart)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (rb.velocity.x < -5)
                {
                    currentVelocity = rb.velocity;
                    targetVelocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                    rb.velocity = Vector3.Lerp(currentVelocity, targetVelocity, 0.1f);
                }
                rb.AddForce(new Vector3(speed, 0, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (rb.velocity.x > 5)
                {
                    currentVelocity = rb.velocity;
                    targetVelocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
                    rb.velocity = Vector3.Lerp(currentVelocity, targetVelocity, 0.1f);
                }
                rb.AddForce(new Vector3(-speed, 0, 0));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (rb.velocity.z < -5)
                {
                    currentVelocity = rb.velocity;
                    targetVelocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
                    rb.velocity = Vector3.Lerp(currentVelocity, targetVelocity, 0.1f);
                }
                rb.AddForce(new Vector3(0, 0, speed));
            }
            if (Input.GetKey(KeyCode.DownArrow))
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
    }
    void Update()
    {
        if (StartTimer.isStart)
        {
            if (Input.GetKeyDown(KeyCode.RightShift) && gameObject.transform.position.y < .5)
            {
                rb.AddForce(new Vector3(0, 330, 0));
                P2_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 330, 0));
            }

            if (Input.GetKeyDown(KeyCode.RightControl) && p2skill)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    rb.AddForce(new Vector3(skillSpeed, 0, 0));
                    p2skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P2_Clone.activeSelf)
                    {
                        P2_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(skillSpeed, 0, 0));
                        P2CloneController.useSkill = true;
                    }
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rb.AddForce(new Vector3(-skillSpeed, 0, 0));
                    p2skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P2_Clone.activeSelf)
                    {
                        P2_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(-skillSpeed, 0, 0));
                        P2CloneController.useSkill = true;
                    }
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rb.AddForce(new Vector3(0, 0, skillSpeed));
                    p2skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P2_Clone.activeSelf)
                    {
                        P2_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, skillSpeed));
                        P2CloneController.useSkill = true;
                    }
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rb.AddForce(new Vector3(0, 0, -skillSpeed));
                    p2skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P2_Clone.activeSelf)
                    {
                        P2_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -skillSpeed));
                        P2CloneController.useSkill = true;
                    }
                }
            }
        }
    }
    private void OnCollisionEnter(Collision obj)
    {
        if (isDashing && (obj.gameObject.CompareTag("P1") || obj.gameObject.CompareTag("C1")))
        {
            boomer2.DestroyP1(obj, this.transform.position);

            Destroy(GameObject.FindGameObjectWithTag("trash"), 12);    // GPT'NİN ÖNERDİĞİ KODU DENE
        }
    }
    IEnumerator ResetSkill()
    {
        cd = 0;
        while (true)
        {
            cd += Time.deltaTime;
            skillImage.fillAmount = cd / cdTime;
            if (cd >= cdTime)
            {
                p2skill = true;
                sound.Play();
                break;
            }
            yield return null;
        }
    }
    private void ResetisDashing()
    {
        isDashing = false;
        CrystallizeDashEffect.Stop();
        P2CloneController.useSkill = false;
    }
    private void ResetTokenEffects()
    {
        if (speed != 25) // Speed Up Token
        {
            speed = 25;
        }
        if (isDashing) // Crystallize Token
        {                    
            isDashing = false;
        }
        if (isCrystallize) // Crystallize Token
        {
            isCrystallize = false;
        }
        body.GetComponent<Renderer>().material = P2Material; // Crystallize Token
        if (cdTime != 10) // Energy Token
        {
            cdTime = 10;
        }
        if (!barrier1.activeSelf) // Erase Token
        {
            barrier1.SetActive(true);
        }
    }
}