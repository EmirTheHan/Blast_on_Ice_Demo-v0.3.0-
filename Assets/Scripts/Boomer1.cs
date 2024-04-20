using UnityEngine;
using UnityEngine.UI;
public class Boomer1 : MonoBehaviour
{
    public Spawner spawner;
    public Image SpeedUpToken, CrystallizeToken, EnergyToken, TimelessToken, EraseToken, AggressiveToken, CloneToken;
    public GameObject b, s1, s2, lightning1, lightning2, p2skillImage, P2CloneBody;
    public Material centerMaterial, Player2Material;
    public Light l1, l2, groundLight;
    public GameObject p2boom;
    public GameObject sparkBoom;
    public GameObject BBoom;
    public GameObject p2;
    public AudioSource d, sparkSound;
    private float speed;
    private void OnCollisionEnter(Collision obj)
    {
        if ((obj.gameObject.CompareTag("P2") || obj.gameObject.CompareTag("C2")) && b.activeSelf)
        {
            DestroyP2(obj);

            Destroy(GameObject.FindGameObjectWithTag("trash"), 12);
        }
        else if (obj.gameObject.CompareTag("B") && BallManager.owner == 2)
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
        P2CloneBody.GetComponent<Renderer>().material = Player2Material;
    }
    public void DestroyP2(Collision obj, Vector3? position = null)
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
        Instantiate(p2boom, obj.transform.position, obj.transform.rotation);
        obj.gameObject.SetActive(false);
        obj.gameObject.GetComponent<Rigidbody>().Sleep();
        if (obj.gameObject.CompareTag("P2"))
        {
            spawner.isSpawnP2 = true;
            p2skillImage.SetActive(false);
            ResetAllTokens();
        }
        else if (obj.gameObject.CompareTag("C2"))
        {
            Boomer1Ctrller.isC2Inside = false;
            CloneToken.fillAmount = 0;
        }
        sparkSound.Play();
    }
}
