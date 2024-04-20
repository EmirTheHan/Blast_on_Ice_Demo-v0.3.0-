using UnityEngine;
using UnityEngine.UI;
public class Boomer2 : MonoBehaviour
{
    public Spawner spawner;
    public Image SpeedUpToken, CrystallizeToken, EnergyToken, TimelessToken, EraseToken, AggressiveToken, CloneToken;
    public GameObject b, s1, s2, lightning1, lightning2, p1skillImage, P1CloneBody;
    public Material centerMaterial, Player1Material;
    public Light l1, l2, groundLight;
    public GameObject p1boom;
    public GameObject sparkBoom;
    public GameObject BBoom;
    public GameObject p1;
    public AudioSource d, sparkSound;
    private float speed;
    private void OnCollisionEnter(Collision obj)
    {
        if ((obj.gameObject.CompareTag("P1") || obj.gameObject.CompareTag("C1")) && b.activeSelf)
        {
            DestroyP1(obj);

            Destroy(GameObject.FindGameObjectWithTag("trash"), 12);
        }
        else if (obj.gameObject.CompareTag("B") && BallManager.owner == 1)
        {
            obj.gameObject.SetActive(false);
            Instantiate(BBoom, obj.transform.position, obj.transform.rotation);
            sparkBoom.GetComponent<ParticleSystem>().Play();
            sparkSound.Play();

            DeActivate();
            Invoke("Activate", 4.5f);

            spawner.isSpawnBall = true;

            Destroy(GameObject.FindGameObjectWithTag("trash"), 12);
        }
        else
        {
            speed = obj.rigidbody.velocity.magnitude;
            if (speed >= 2)
            {
                d.volume = .25f * speed;
                d.Play();
            }
        }
    }
    public void Activate()
    {
        if (!EndGame.Gameover)
        {
            s1.SetActive(true);
            l1.enabled = true;
            lightning1.SetActive(true);

            s2.SetActive(true);
            l2.enabled = true;
            lightning2.SetActive(true);

            groundLight.enabled = false;
            centerMaterial.color = Color.white;
        }
    }
    public void DeActivate()
    {
        if (!EndGame.Gameover)
        {
            s1.SetActive(false);
            l1.enabled = false;
            lightning1.SetActive(false);

            s2.SetActive(false);
            l2.enabled = false;
            lightning2.SetActive(false);

            groundLight.enabled = true;
            centerMaterial.color = Color.red;
        }
    }
    public void ResetAllTokens()
    {
        SpeedUpToken.fillAmount = 0;
        CrystallizeToken.fillAmount = 0;
        EnergyToken.fillAmount = 0;
        EraseToken.fillAmount = 0;
        AggressiveToken.fillAmount = 0;
        if (EndGame.Gameover)
        {
            TimelessToken.fillAmount = 0;
            CloneToken.fillAmount = 0;
        }
        P1CloneBody.GetComponent<Renderer>().material = Player1Material;
    }
    public void DestroyP1(Collision obj, Vector3? position = null)
    {
        if (position.HasValue)
        {
            sparkBoom.transform.position = position.Value;
            sparkBoom.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            sparkBoom.transform.position = transform.position;
            sparkBoom.GetComponent<ParticleSystem>().Play();
        }
        Instantiate(p1boom, obj.transform.position, obj.transform.rotation);
        obj.gameObject.SetActive(false);
        obj.gameObject.GetComponent<Rigidbody>().Sleep();
        if (obj.gameObject.CompareTag("P1"))
        {
            spawner.isSpawnP1 = true;
            p1skillImage.SetActive(false);
            ResetAllTokens();
        }
        else if (obj.gameObject.CompareTag("C1"))
        {
            Boomer2Ctrller.isC1Inside = false;
            CloneToken.fillAmount = 0;
        }
        sparkSound.Play();
    }
}