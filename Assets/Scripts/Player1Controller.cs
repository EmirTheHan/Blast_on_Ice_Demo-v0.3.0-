using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Player1Controller : MonoBehaviour
{
    public NavMeshAgent barrier1;
    public Spawner spawner;
    public Boomer1 boomer1;
    public ParticleSystem CrystallizeDashEffect;
    public Material P1Material;
    public GameObject body, barrier2, P1_Clone;
    public static bool p1skill, isCrystallize = false, isDashing = false;
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
        p1skill = true;
    }
    private void FixedUpdate()
    {
        if (StartTimer.isStart)
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
                //DirectionMark.transform.rotation = Quaternion.Euler(0, 0, 0);
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
                //DirectionMark.transform.rotation = Quaternion.Euler(0, 180, 0);
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
                //DirectionMark.transform.rotation = Quaternion.Euler(0, -90, 0);
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
                //DirectionMark.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
        }
    }
    void Update()
    {
        if (StartTimer.isStart)
        {
            if (Input.GetKeyDown(KeyCode.Space) && gameObject.transform.position.y < .5)
            {
                rb.AddForce(new Vector3(0, 330, 0));
                P1_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 330, 0));
            }

            if (Input.GetKeyDown(KeyCode.LeftShift) && p1skill)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    rb.AddForce(new Vector3(skillSpeed, 0, 0));
                    p1skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P1_Clone.activeSelf)
                    {
                        P1_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(skillSpeed, 0, 0));
                        P1CloneController.useSkill = true;
                    }
                }
                if (Input.GetKey(KeyCode.A))
                {
                    rb.AddForce(new Vector3(-skillSpeed, 0, 0));
                    p1skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P1_Clone.activeSelf)
                    {
                        P1_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(-skillSpeed, 0, 0));
                        P1CloneController.useSkill = true;
                    }
                }
                if (Input.GetKey(KeyCode.W))
                {
                    rb.AddForce(new Vector3(0, 0, skillSpeed));
                    p1skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P1_Clone.activeSelf)
                    {
                        P1_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, skillSpeed));
                        P1CloneController.useSkill = true;
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    rb.AddForce(new Vector3(0, 0, -skillSpeed));
                    p1skill = false;
                    dashS.Play();
                    StartCoroutine(ResetSkill());
                    if (isCrystallize)
                    {
                        isDashing = true;
                        CrystallizeDashEffect.Play();
                        Invoke("ResetisDashing", 1.2f);
                    }
                    if (P1_Clone.activeSelf)
                    {
                        P1_Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -skillSpeed));
                        P1CloneController.useSkill = true;
                    }
                }
            }
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
    IEnumerator ResetSkill()
    {
        cd = 0;
        while (true)
        {
            cd += Time.deltaTime;
            skillImage.fillAmount = cd / cdTime;
            if (cd >= cdTime)
            {
                p1skill = true;
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
        P1CloneController.useSkill = false;
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
        body.GetComponent<Renderer>().material = P1Material; // Crystallize Token
        if (cdTime != 10) // Energy Token
        {
            cdTime = 10;
        }
        if (!barrier2.activeSelf) // Erase Token
        {
            barrier2.SetActive(true);
        }
    }
}
