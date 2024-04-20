using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    [SerializeField] private Material p1, p2, ball, b1, b2;
    [SerializeField] private Image p1S, p2S;
    [SerializeField] private Light b1L, b2L;
    [SerializeField] private ParticleSystem p1B, p2B, ballB, b1S, b2S, b1Lightning, b2Lightning, b1SBoom, b2SBoom, P1CrystallizeDash, P2CrystallizeDash;
    [SerializeField] private Texture desen1, desen2, desen3, desen4;

    [System.Obsolete]
    void Start()
    {
        Yellow1();
        Purple2();
        RedB();
    }

    [System.Obsolete]
    public void Red1()
    {
        b1L.enabled = true;
        b1L.intensity = 8;
        b1S.startColor = Color.red;
        b1Lightning.startColor = Color.red;
        P1CrystallizeDash.startColor = Color.red;
        b1SBoom.startColor = Color.red;
        p1.color = new Color(.8f, 0, 0);
        b1.color = Color.red;
        b1.SetColor("_EmissionColor", new Color(0.2509804f, 0f, 0f));
        p1S.color = new Color(1, 0, 0, 0.5f);
        b1L.color = Color.red;
        p1B.startColor = Color.red;
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.red;
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.red;
    }
    [System.Obsolete]
    public void Red2()
    {
        b2L.enabled = true;
        b2L.intensity = 8;
        b2S.startColor = Color.red;
        b2Lightning.startColor = Color.red;
        P2CrystallizeDash.startColor = Color.red;
        b2SBoom.startColor = Color.red;
        p2.color = new Color(.8f, 0, 0);
        b2.color = Color.red;
        b2.SetColor("_EmissionColor", new Color(0.2509804f, 0f, 0f));
        p2S.color = new Color(1, 0, 0, 0.5f);
        b2L.color = Color.red;
        p2B.startColor = Color.red;
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.red;
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.red;
    }
    [System.Obsolete]
    public void Pink1()
    {
        b1L.enabled = true;
        b1L.intensity = 7;
        b1S.startColor = new Color(1, 0, 0.61f);
        b1Lightning.startColor = new Color(1, 0, 0.61f);
        P1CrystallizeDash.startColor = new Color(1, 0, 0.61f);
        b1SBoom.startColor = new Color(1, 0, 0.61f);
        p1.color = new Color(.9f, 0, 0.5f);
        b1.color = new Color(.7f, 0, 0.5f);
        b1.SetColor("_EmissionColor", new Color(0.5f, 0, 0.35f));
        p1S.color = new Color(1, 0, 0.61f, 0.5f);
        b1L.color = new Color(1, 0, 0.61f);
        p1B.startColor = new Color(1, 0, 0.61f);
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0.61f);
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0.61f);
    }
    [System.Obsolete]
    public void Pink2()
    {
        b2L.enabled = true;
        b2L.intensity = 7;
        b2S.startColor = new Color(1, 0, 0.61f);
        b2Lightning.startColor = new Color(1, 0, 0.61f);
        P2CrystallizeDash.startColor = new Color(1, 0, 0.61f); 
        b2SBoom.startColor = new Color(1, 0, 0.61f);
        p2.color = new Color(.9f, 0, 0.5f);
        b2.color = new Color(.7f, 0, 0.5f);
        b2.SetColor("_EmissionColor", new Color(0.5f, 0, 0.35f));
        p2S.color = new Color(1, 0, 0.61f, 0.5f);
        b2L.color = new Color(1, 0, 0.61f);
        p2B.startColor = new Color(1, 0, 0.61f);
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0.61f);
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0.61f);
    }
    [System.Obsolete]
    public void Blue1()
    {
        b1L.enabled = true;
        b1L.intensity = 7;
        b1S.startColor = new Color(0, .5f, 1);
        b1Lightning.startColor = new Color(0, .5f, 1);
        P1CrystallizeDash.startColor = new Color(0, .5f, 1);
        b1SBoom.startColor = new Color(0, .5f, 1);
        p1.color = new Color(0, .3f, .7f);
        b1.color = new Color(0, .3f, .7f);
        b1.SetColor("_EmissionColor", new Color(0, 0.21f, 0.24f));
        p1S.color = new Color(0, .5f, 1, 0.5f);
        b1L.color = new Color(0, .5f, 1);
        p1B.startColor = new Color(0, 0.87f, 0.98f);
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0, .5f, 1);
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0, .5f, 1);
    }
    [System.Obsolete]
    public void Blue2()
    {
        b2L.enabled = true;
        b2L.intensity = 7;
        b2S.startColor = new Color(0, .5f, 1);
        b2Lightning.startColor = new Color(0, .5f, 1);
        P2CrystallizeDash.startColor = new Color(0, .5f, 1);
        b2SBoom.startColor = new Color(0, .5f, 1);
        p2.color = new Color(0, .3f, .7f);
        b2.color = new Color(0, .3f, .7f);
        b2.SetColor("_EmissionColor", new Color(0, 0.21f, 0.24f));
        p2S.color = new Color(0, .5f, 1, 0.5f);
        b2L.color = new Color(0, .5f, 1);
        p2B.startColor = new Color(0, .5f, 1);
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0, .5f, 1);
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0, .5f, 1);
    }
    [System.Obsolete]
    public void Yellow1()
    {
        b1L.enabled = true;
        b1L.intensity = 7;
        b1S.startColor = Color.yellow;
        b1Lightning.startColor = Color.yellow;
        P1CrystallizeDash.startColor = Color.yellow;
        b1SBoom.startColor = Color.yellow;
        p1.color = Color.yellow;
        b1.color = Color.yellow;
        b1.SetColor("_EmissionColor", new Color(0.25f, 0.23f, 0));
        p1S.color = new Color(1, 1, 0, 0.5f);
        b1L.color = Color.yellow;
        p1B.startColor = Color.yellow;
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.yellow;
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.yellow;
    }
    [System.Obsolete]
    public void Yellow2()
    {
        b2L.enabled = true;
        b2L.intensity = 7;
        b2S.startColor = Color.yellow;
        b2Lightning.startColor = Color.yellow;
        P2CrystallizeDash.startColor = Color.yellow;
        b2SBoom.startColor = Color.yellow;
        p2.color = Color.yellow;
        b2.color = Color.yellow;
        b2.SetColor("_EmissionColor", new Color(0.25f, 0.23f, 0));
        p2S.color = new Color(1, 1, 0, 0.5f);
        b2L.color = Color.yellow;
        p2B.startColor = Color.yellow;
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.yellow;
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.yellow;
    }
    [System.Obsolete]
    public void White1()
    {
        b1L.enabled = true;
        b1L.intensity = 4f;
        b1S.startColor = Color.white;
        b1Lightning.startColor = Color.white;
        P1CrystallizeDash.startColor = Color.white;
        b1SBoom.startColor = Color.white;
        p1.color = Color.white;
        b1.color = Color.white;
        b1.SetColor("_EmissionColor", new Color(.25f, .25f, .25f));
        p1S.color = new Color(1, 1, 1, 0.5f);
        b1L.color = Color.white;
        p1B.startColor = Color.white;
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.white;
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.white;
    }
    [System.Obsolete]
    public void White2()
    {
        b2L.enabled = true;
        b2L.intensity = 4f;
        b2S.startColor = Color.white;
        b2Lightning.startColor = Color.white;
        P2CrystallizeDash.startColor = Color.white;
        b2SBoom.startColor = Color.white;
        p2.color = Color.white;
        b2.color = Color.white;
        b2.SetColor("_EmissionColor", new Color(.25f, .25f, .25f));
        p2S.color = new Color(1, 1, 1, 0.5f);
        b2L.color = Color.white;
        p2B.startColor = Color.white;
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.white;
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.white;
    }
    [System.Obsolete]
    public void Black1()
    {
        b1S.startColor = new Color(0.05f, 0.05f, 0.05f);
        b1Lightning.startColor = new Color(0.05f, 0.05f, 0.05f);
        P1CrystallizeDash.startColor = new Color(0.05f, 0.05f, 0.05f);
        b1SBoom.startColor = new Color(0.05f, 0.05f, 0.05f);
        p1.color = new Color(0.05f, 0.05f, 0.05f);
        b1.color = new Color(0.05f, 0.05f, 0.05f);
        b1.SetColor("_EmissionColor", Color.black);
        p1S.color = new Color(0.05f, 0.05f, 0.05f, 0.7f);
        b1L.color = new Color(0.05f, 0.05f, 0.05f);
        b2L.enabled = false;
        p1B.startColor = new Color(0.05f, 0.05f, 0.05f);
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.05f, 0.05f, 0.05f);
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0.05f, 0.05f, 0.05f);
    }
    [System.Obsolete]
    public void Black2()
    {
        b2S.startColor = new Color(0.05f, 0.05f, 0.05f);
        b2Lightning.startColor = new Color(0.05f, 0.05f, 0.05f);
        P2CrystallizeDash.startColor = new Color(0.05f, 0.05f, 0.05f);
        b2SBoom.startColor = new Color(0.05f, 0.05f, 0.05f);
        p2.color = new Color(0.05f, 0.05f, 0.05f);
        b2.color = new Color(0.05f, 0.05f, 0.05f);
        b2.SetColor("_EmissionColor", Color.black);
        p2S.color = new Color(0.05f, 0.05f, 0.05f, .7f);
        b2L.color = new Color(0.05f, 0.05f, 0.05f);
        b2L.enabled = false;
        p2B.startColor = new Color(0.05f, 0.05f, 0.05f);
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.05f, 0.05f, 0.05f);
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0.05f, 0.05f, 0.05f);
    }
    [System.Obsolete]
    public void Green1()
    {
        b1L.enabled = true;
        b1L.intensity = 5f;
        b1S.startColor = Color.green;
        b1Lightning.startColor = Color.green;
        P1CrystallizeDash.startColor = Color.green;
        b1SBoom.startColor = Color.green;
        p1.color = new Color(0, .65f, 0);
        b1.color = new Color(0, .9f, 0);
        b1.SetColor("_EmissionColor", new Color(0, .25f, 0));
        p1S.color = new Color(0, 1, 0, 0.5f);
        b1L.color = Color.green;
        p1B.startColor = Color.green;
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.green;
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.green;
    }
    [System.Obsolete]
    public void Green2()
    {
        b2L.enabled = true;
        b2L.intensity = 5f;
        b2S.startColor = Color.green;
        b2Lightning.startColor = Color.green;
        P2CrystallizeDash.startColor = Color.green;
        b2SBoom.startColor = Color.green;
        p2.color = new Color(0, .65f, 0);
        b2.color = new Color(0, .9f, 0);
        b2.SetColor("_EmissionColor", new Color(0, .25f, 0));
        p2S.color = new Color(0, 1, 0, 0.5f);
        b2L.color = Color.green;
        p2B.startColor = Color.green;
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.green;
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = Color.green;
    }
    [System.Obsolete]
    public void Purple1()
    {
        b1L.enabled = true;
        b1L.intensity = 10f;
        b1S.startColor = new Color(0.78f, 0.30f, 1);
        b1Lightning.startColor = new Color(0.78f, 0.30f, 1);
        P1CrystallizeDash.startColor = new Color(0.78f, 0.30f, 1);
        b1SBoom.startColor = new Color(0.5f, 0, 0.8f);
        p1.color = new Color(0.56f, 0.23f, 0.7f);
        b1.color = new Color(0.56f, 0.23f, 0.7f);
        b1.SetColor("_EmissionColor", new Color(0.28f, 0.11f, 0.35f));
        p1S.color = new Color(0.65f, 0f, 1f, .5f);
        b1L.color = new Color(0.56f, 0.23f, 0.7f);
        p1B.startColor = new Color(0.56f, 0.23f, 0.7f);
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.56f, 0.23f, 0.7f);
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0.56f, 0.23f, 0.7f);
    }
    [System.Obsolete]
    public void Purple2()
    {
        b2L.enabled = true;
        b2L.intensity = 10f;
        b2S.startColor = new Color(0.78f, 0.30f, 1);
        b2Lightning.startColor = new Color(0.78f, 0.30f, 1);
        P2CrystallizeDash.startColor = new Color(0.78f, 0.30f, 1);
        b2SBoom.startColor = new Color(0.5f, 0, 0.8f);
        p2.color = new Color(0.56f, 0.23f, 0.7f);
        b2.color = new Color(0.56f, 0.23f, 0.7f);
        b2.SetColor("_EmissionColor", new Color(0.28f, 0.11f, 0.35f));
        p2S.color = new Color(0.65f, 0f, 1f, .5f);
        b2L.color = new Color(0.56f, 0.23f, 0.7f);
        p2B.startColor = new Color(0.56f, 0.23f, 0.7f);
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.56f, 0.23f, 0.7f);
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0.56f, 0.23f, 0.7f);
    }
    [System.Obsolete]
    public void Orange1()
    {
        b1L.enabled = true;
        b1L.intensity = 8f;
        b1S.startColor = new Color(1, 0.662f, 0.447f);
        b1Lightning.startColor = new Color(1, 0.5f, 0.2f);
        P1CrystallizeDash.startColor = new Color(1, 0.5f, 0.2f);
        b1SBoom.startColor = new Color(1, 0.55f, 0);
        p1.color = new Color(1, 0.55f, 0);
        b1.color = new Color(1, 0.55f, 0);
        b1.SetColor("_EmissionColor", new Color(0.453f, 0.247f, 0.070f));
        p1S.color = new Color(1, 0.55f, 0, .5f);
        b1L.color = new Color(1, 0.55f, 0);
        p1B.startColor = new Color(1, 0.55f, 0);
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(1, 0.55f, 0);
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(1, 0.55f, 0);
    }
    [System.Obsolete]
    public void Orange2()
    {
        b2L.enabled = true;
        b2L.intensity = 8f;
        b2S.startColor = new Color(1, 0.662f, 0.447f);
        b2Lightning.startColor = new Color(1, 0.5f, 0.2f);
        P2CrystallizeDash.startColor = new Color(1, 0.5f, 0.2f);
        b2SBoom.startColor = new Color(1, 0.55f, 0);
        p2.color = new Color(1, 0.55f, 0);
        b2.color = new Color(1, 0.55f, 0);
        b2.SetColor("_EmissionColor", new Color(0.453f, 0.247f, 0.070f));
        p2S.color = new Color(1, 0.55f, 0, .5f);
        b2L.color = new Color(1, 0.55f, 0);
        p2B.startColor = new Color(1, 0.55f, 0);
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(1, 0.55f, 0);
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(1, 0.55f, 0);
    }
    [System.Obsolete]
    public void Gray1()
    {
        b1L.enabled = true;
        b1L.intensity = 4;
        b1S.startColor = new Color(0.5f, 0.5f, 0.5f);
        b1Lightning.startColor = new Color(0.4f, 0.4f, 0.4f);
        P1CrystallizeDash.startColor = new Color(0.4f, 0.4f, 0.4f);
        b1SBoom.startColor = new Color(0.4f, 0.4f, 0.4f);
        p1.color = new Color(0.4f, 0.4f, 0.4f);
        b1.color = new Color(0.4f, 0.4f, 0.4f);
        b1.SetColor("_EmissionColor", new Color(0.2f, 0.2f, 0.2f));
        p1S.color = new Color(0.3f, 0.3f, 0.3f, .5f);
        b1L.color = Color.white;
        p1B.startColor = new Color(0.4f, 0.4f, 0.4f);
        p1B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.4f, 0.4f, 0.4f);
        p1B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0.4f, 0.4f, 0.4f);
    }
    [System.Obsolete]
    public void Gray2()
    {
        b2L.enabled = true;
        b2L.intensity = 4;
        b2S.startColor = new Color(0.5f, 0.5f, 0.5f);
        b2Lightning.startColor = new Color(0.4f, 0.4f, 0.4f);
        P2CrystallizeDash.startColor = new Color(0.4f, 0.4f, 0.4f);
        b2SBoom.startColor = new Color(0.4f, 0.4f, 0.4f);
        p2.color = new Color(0.4f, 0.4f, 0.4f);
        b2.color = new Color(0.4f, 0.4f, 0.4f);
        b2.SetColor("_EmissionColor", new Color(0.2f, 0.2f, 0.2f));
        p2S.color = new Color(0.3f, 0.3f, 0.3f, .5f);
        b2L.color = Color.white;
        p2B.startColor = new Color(0.4f, 0.4f, 0.4f);
        p2B.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.4f, 0.4f, 0.4f);
        p2B.transform.GetChild(2).GetComponent<ParticleSystem>().startColor = new Color(0.4f, 0.4f, 0.4f);
    }
    [System.Obsolete]
    public void RedB()
    {
        ball.color = Color.red;
        ballB.startColor = Color.red;
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.red;
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = Color.red;
    }
    [System.Obsolete]
    public void PinkB()
    {
        ball.color = new Color(1, 0, 0.7060366f);
        ballB.startColor = new Color(1, 0, 0.7060366f);
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0.7060366f);
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0.7060366f);
    }
    [System.Obsolete]
    public void BlueB()
    {
        ball.color = new Color(0, 0.8675501f, 0.9811321f);
        ballB.startColor = new Color(0, 0.8675501f, 0.9811321f);
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0, 0.8675501f, 0.9811321f);
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = new Color(0, 0.8675501f, 0.9811321f);
    }
    [System.Obsolete]
    public void YellowB()
    {
        ball.color = Color.yellow;
        ballB.startColor = Color.yellow;
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.yellow;
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = Color.yellow;
    }
    [System.Obsolete]
    public void WhiteB()
    {
        ball.color = Color.white;
        ballB.startColor = Color.white;
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.white;
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = Color.white;
    }
    [System.Obsolete]
    public void BlackB()
    {
        ball.color = new Color(0.2f, 0.2f, 0.2f);
        ballB.startColor = Color.black;
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.black;
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = Color.black;
    }
    [System.Obsolete]
    public void GreenB()
    {
        ball.color = Color.green;
        ballB.startColor = Color.green;
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = Color.green;
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = Color.green;
    }
    [System.Obsolete]
    public void GrayB()
    {
        ball.color = new Color(0.5f, 0.5f, 0.5f);
        ballB.startColor = new Color(0.5f, 0.5f, 0.5f);
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.5f, 0.5f, 0.5f);
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = new Color(0.5f, 0.5f, 0.5f);
    }
    [System.Obsolete]
    public void OrangeB()
    {
        ball.color = new Color(1, 0.37f, 0);
        ballB.startColor = new Color(1, 0.37f, 0);
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(1, 0.37f, 0);
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = new Color(1, 0.37f, 0);
    }
    [System.Obsolete]
    public void PurpleB()
    {
        ball.color = new Color(0.5607683f, 0.2272161f, 0.6981132f);
        ballB.startColor = new Color(0.5607683f, 0.2272161f, 0.6981132f);
        ballB.transform.GetChild(0).GetComponent<ParticleSystem>().startColor = new Color(0.5607683f, 0.2272161f, 0.6981132f);
        ballB.transform.GetChild(1).GetComponent<ParticleSystem>().startColor = new Color(0.5607683f, 0.2272161f, 0.6981132f);
    }
    public void Transparent_ON()
    {
        ball.SetFloat("_Metallic", 0);
    }
    public void Transparent_OFF()
    {
        ball.SetFloat("_Metallic", 1);
    }
    public void Desen_1()
    {
        ball.SetTexture("_MainTex", desen1);
    }
    public void Desen_2()
    {
        ball.SetTexture("_MainTex", desen2);
    }
    public void Desen_3()
    {
        ball.SetTexture("_MainTex", desen3);
    }
    public void Desen_4()
    {
        ball.SetTexture("_MainTex", desen4);
    }
}
