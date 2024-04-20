using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class GoalControl2 : MonoBehaviour
{
    public Token_Spawner tokenSpawner;
    public Spawner spawner;
    int k = 0;
    public Animator anm;
    public Material centerMaterial;
    public Light light1, light2, groundLight;
    public GameObject Bboom, spark1, spark2, lightning1, lightning2;
    AudioSource fan2sound;
    public static int puan2;
    public Text scorboard2;
    private void OnEnable()
    {
        puan2 = 0;
        fan2sound = GetComponent<AudioSource>();
        scorboard2.text = puan2.ToString();
    }
    private void OnTriggerEnter(Collider go)
    {
        if (go.gameObject.CompareTag("B"))
        {
            SlowMotion();

            go.gameObject.SetActive(false);
            Instantiate(Bboom, go.transform.position, transform.rotation);

            DeActivate();
            Invoke("Activate", 4.5f);

            puan2++;
            scorboard2.text = puan2.ToString();
            fan2sound.Play();

            Invoke(nameof(Set_k), .7f);
            Invoke(nameof(Reset_k), 1);

            Destroy(GameObject.FindGameObjectWithTag("trash"), 12);
            if (puan2 != 5)
            {
                spawner.isSpawnBall = true;
            }
            tokenSpawner.TokenTime = true;
        }
    }
    private void SlowMotion()
    {
        Time.timeScale = 0.2f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f;
    }
    private void Activate()
    {
        if (!EndGame.Gameover)
        {
            spark1.SetActive(true);
            light1.enabled = true;
            lightning1.SetActive(true);
            spark2.SetActive(true);
            light2.enabled = true;
            lightning2.SetActive(true);
            groundLight.enabled = false;
            centerMaterial.color = Color.white;
        }
    }
    private void DeActivate()
    {
        spark1.SetActive(false);
        spark2.SetActive(false);
        lightning1.SetActive(false);
        lightning2.SetActive(false);
        light1.enabled = false;
        light2.enabled = false;
        groundLight.enabled = true;
        centerMaterial.color = Color.red;
    }

    public void Set_k()
    {
        k = Random.Range(1, 6);
        anm.SetInteger("k", k);
    }
    public void Reset_k()
    {
        k = 0;
        anm.SetInteger("k", k);
    }
}

