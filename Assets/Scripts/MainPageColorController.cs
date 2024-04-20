using System.Collections.Generic;
using UnityEngine;
using System;

public class MainPageColorController : MonoBehaviour
{
    [SerializeField] private Material p1, p2, ball, b1, b2;
    [SerializeField] private Light b1L, b2L;
    [SerializeField] private ParticleSystem b1S, b2S, b1Lightning, b2Lightning;

    List<Action> colorFunctions = new();

    [System.Obsolete]
    void Start()
    {
        colorFunctions.Add(Red1);
        colorFunctions.Add(Red2);
        colorFunctions.Add(Pink1);
        colorFunctions.Add(Pink2);
        colorFunctions.Add(Blue1);
        colorFunctions.Add(Blue2);
        colorFunctions.Add(Yellow1);
        colorFunctions.Add(Yellow2);
        colorFunctions.Add(White1);
        colorFunctions.Add(White2);
        colorFunctions.Add(Black1);
        colorFunctions.Add(Black2);
        colorFunctions.Add(Green1);
        colorFunctions.Add(Green2);
        colorFunctions.Add(Purple1);
        colorFunctions.Add(Purple2);
        colorFunctions.Add(Orange1);
        colorFunctions.Add(Orange2);
        colorFunctions.Add(Gray1);
        colorFunctions.Add(Gray2);
        colorFunctions.Add(RedB);
        colorFunctions.Add(PinkB);
        colorFunctions.Add(BlueB);
        colorFunctions.Add(YellowB);
        colorFunctions.Add(WhiteB);
        colorFunctions.Add(BlackB);
        colorFunctions.Add(GreenB);
        colorFunctions.Add(PurpleB);
        colorFunctions.Add(OrangeB);
        colorFunctions.Add(GrayB);

        InvokeRepeating(nameof(GetColor), 0, 1)
;    }

    private void GetColor()
    {
        System.Random rand = new();
        int index = rand.Next(colorFunctions.Count);
        colorFunctions[index]();
    }

    [System.Obsolete]
    public void Red1()
    {
        b1L.enabled = true;
        b1L.intensity = 7;
        b1S.startColor = Color.red;
        b1Lightning.startColor = Color.red;
        p1.color = Color.red;
        b1.color = Color.red;
        b1.SetColor("_EmissionColor", new Color(0.2509804f, 0f, 0f));
        b1L.color = Color.red;
    }
    [System.Obsolete]
    public void Red2()
    {
        b2L.enabled = true;
        b2L.intensity = 7;
        b2S.startColor = Color.red;
        b2Lightning.startColor = Color.red;
        p2.color = Color.red;
        b2.color = Color.red;
        b2.SetColor("_EmissionColor", new Color(0.2509804f, 0f, 0f));
        b2L.color = Color.red;
    }
    [System.Obsolete]
    public void Pink1()
    {
        b1L.enabled = true;
        b1L.intensity = 6;
        b1S.startColor = new Color(1, 0, 0.61f);
        b1Lightning.startColor = new Color(1, 0, 0.61f);
        p1.color = new Color(1, 0, 0.61f);
        b1.color = new Color(1, 0, 0.61f);
        b1.SetColor("_EmissionColor", new Color(0.5f, 0, 0.35f));
        b1L.color = new Color(1, 0, 0.61f);
    }
    [System.Obsolete]
    public void Pink2()
    {
        b2L.enabled = true;
        b2L.intensity = 6;
        b2S.startColor = new Color(1, 0, 0.61f);
        b2Lightning.startColor = new Color(1, 0, 0.61f);
        p2.color = new Color(1, 0, 0.61f);
        b2.color = new Color(1, 0, 0.61f);
        b2.SetColor("_EmissionColor", new Color(0.5f, 0, 0.35f));
        b2L.color = new Color(1, 0, 0.61f);
    }
    [System.Obsolete]
    public void Blue1()
    {
        b1L.enabled = true;
        b1L.intensity = 7;
        b1S.startColor = new Color(0, .5f, 1);
        b1Lightning.startColor = new Color(0, .5f, 1);
        p1.color = new Color(0, .5f, 1);
        b1.color = new Color(0, .5f, 1);
        b1.SetColor("_EmissionColor", new Color(0, 0.21f, 0.24f));
        b1L.color = new Color(0, .5f, 1);
    }
    [System.Obsolete]
    public void Blue2()
    {
        b2L.enabled = true;
        b2L.intensity = 7;
        b2S.startColor = new Color(0, .5f, 1);
        b2Lightning.startColor = new Color(0, .5f, 1);
        p2.color = new Color(0, .5f, 1);
        b2.color = new Color(0, .5f, 1);
        b2.SetColor("_EmissionColor", new Color(0, 0.21f, 0.24f));
        b2L.color = new Color(0, .5f, 1);
    }
    [System.Obsolete]
    public void Yellow1()
    {
        b1L.enabled = true;
        b1L.intensity = 3.5f;
        b1S.startColor = Color.yellow;
        b1Lightning.startColor = Color.yellow;
        p1.color = Color.yellow;
        b1.color = Color.yellow;
        b1.SetColor("_EmissionColor", new Color(0.25f, 0.23f, 0));
        b1L.color = Color.yellow;
    }
    [System.Obsolete]
    public void Yellow2()
    {
        b2L.enabled = true;
        b2L.intensity = 3.5f;
        b2S.startColor = Color.yellow;
        b2Lightning.startColor = Color.yellow;
        p2.color = Color.yellow;
        b2.color = Color.yellow;
        b2.SetColor("_EmissionColor", new Color(0.25f, 0.23f, 0));
        b2L.color = Color.yellow;
    }
    [System.Obsolete]
    public void White1()
    {
        b1L.enabled = true;
        b1L.intensity = 4f;
        b1S.startColor = Color.white;
        b1Lightning.startColor = Color.white;
        p1.color = Color.white;
        b1.color = Color.white;
        b1.SetColor("_EmissionColor", new Color(.25f, .25f, .25f));
        b1L.color = Color.white;
    }
    [System.Obsolete]
    public void White2()
    {
        b2L.enabled = true;
        b2L.intensity = 4f;
        b2S.startColor = Color.white;
        b2Lightning.startColor = Color.white;
        p2.color = Color.white;
        b2.color = Color.white;
        b2.SetColor("_EmissionColor", new Color(.25f, .25f, .25f));
        b2L.color = Color.white;
    }
    [System.Obsolete]
    public void Black1()
    {
        b1S.startColor = new Color(0.05f, 0.05f, 0.05f);
        b1Lightning.startColor = new Color(0.05f, 0.05f, 0.05f);
        p1.color = new Color(0.05f, 0.05f, 0.05f);
        b1.color = new Color(0.05f, 0.05f, 0.05f);
        b1.SetColor("_EmissionColor", Color.black);
        b1L.color = new Color(0.05f, 0.05f, 0.05f);
        b2L.enabled = false;
    }
    [System.Obsolete]
    public void Black2()
    {
        b2S.startColor = new Color(0.05f, 0.05f, 0.05f);
        b2Lightning.startColor = new Color(0.05f, 0.05f, 0.05f);
        p2.color = new Color(0.05f, 0.05f, 0.05f);
        b2.color = new Color(0.05f, 0.05f, 0.05f);
        b2.SetColor("_EmissionColor", Color.black);
        b2L.enabled = false;
    }
    [System.Obsolete]
    public void Green1()
    {
        b1L.enabled = true;
        b1L.intensity = 5f;
        b1S.startColor = Color.green;
        b1Lightning.startColor = Color.green;
        p1.color = Color.green;
        b1.color = Color.green;
        b1.SetColor("_EmissionColor", new Color(0, .25f, 0));
        b1L.color = Color.green;
    }
    [System.Obsolete]
    public void Green2()
    {
        b2L.enabled = true;
        b2L.intensity = 5f;
        b2S.startColor = Color.green;
        b2Lightning.startColor = Color.green;
        p2.color = Color.green;
        b2.color = Color.green;
        b2.SetColor("_EmissionColor", new Color(0, .25f, 0));
        b2L.color = Color.green;
    }
    [System.Obsolete]
    public void Purple1()
    {
        b1L.enabled = true;
        b1L.intensity = 10f;
        b1S.startColor = new Color(0.78f, 0.30f, 1);
        b1Lightning.startColor = new Color(0.78f, 0.30f, 1);
        p1.color = new Color(0.56f, 0.23f, 0.7f);
        b1.color = new Color(0.56f, 0.23f, 0.7f);
        b1.SetColor("_EmissionColor", new Color(0.28f, 0.11f, 0.35f));
        b1L.color = new Color(0.56f, 0.23f, 0.7f);
    }
    [System.Obsolete]
    public void Purple2()
    {
        b2L.enabled = true;
        b2L.intensity = 10f;
        b2S.startColor = new Color(0.78f, 0.30f, 1);
        b2Lightning.startColor = new Color(0.78f, 0.30f, 1);
        p2.color = new Color(0.56f, 0.23f, 0.7f);
        b2.color = new Color(0.56f, 0.23f, 0.7f);
        b2.SetColor("_EmissionColor", new Color(0.28f, 0.11f, 0.35f));
        b2L.color = new Color(0.56f, 0.23f, 0.7f);
    }
    [System.Obsolete]
    public void Orange1()
    {
        b1L.enabled = true;
        b1L.intensity = 8f;
        b1S.startColor = new Color(1, 0.662f, 0.447f);
        b1Lightning.startColor = new Color(1, 0.5f, 0.2f);        p1.color = new Color(1, 0.55f, 0);
        b1.color = new Color(1, 0.55f, 0);
        b1.SetColor("_EmissionColor", new Color(0.453f, 0.247f, 0.070f));
        b1L.color = new Color(1, 0.55f, 0);
    }
    [System.Obsolete]
    public void Orange2()
    {
        b2L.enabled = true;
        b2L.intensity = 8f;
        b2S.startColor = new Color(1, 0.662f, 0.447f);
        b2Lightning.startColor = new Color(1, 0.5f, 0.2f);
        p2.color = new Color(1, 0.55f, 0);
        b2.color = new Color(1, 0.55f, 0);
        b2.SetColor("_EmissionColor", new Color(0.453f, 0.247f, 0.070f));
        b2L.color = new Color(1, 0.55f, 0);
    }
    [System.Obsolete]
    public void Gray1()
    {
        b1L.enabled = true;
        b1L.intensity = 4;
        b1S.startColor = new Color(0.5f, 0.5f, 0.5f);
        b1Lightning.startColor = new Color(0.4f, 0.4f, 0.4f);
        p1.color = new Color(0.4f, 0.4f, 0.4f);
        b1.color = new Color(0.4f, 0.4f, 0.4f);
        b1.SetColor("_EmissionColor", new Color(0.2f, 0.2f, 0.2f));
        b1L.color = Color.white;
    }
    [System.Obsolete]
    public void Gray2()
    {
        b2L.enabled = true;
        b2L.intensity = 4;
        b2S.startColor = new Color(0.5f, 0.5f, 0.5f);
        b2Lightning.startColor = new Color(0.4f, 0.4f, 0.4f);
        p2.color = new Color(0.4f, 0.4f, 0.4f);
        b2.color = new Color(0.4f, 0.4f, 0.4f);
        b2.SetColor("_EmissionColor", new Color(0.2f, 0.2f, 0.2f));
        b2L.color = Color.white;
    }
    [System.Obsolete]
    public void RedB()
    {
        ball.color = Color.red;
    }
    [System.Obsolete]
    public void PinkB()
    {
        ball.color = new Color(1, 0, 0.7060366f);
    }
    [System.Obsolete]
    public void BlueB()
    {
        ball.color = new Color(0, 0.8675501f, 0.9811321f);
    }
    [System.Obsolete]
    public void YellowB()
    {
        ball.color = Color.yellow;
    }
    [System.Obsolete]
    public void WhiteB()
    {
        ball.color = Color.white;
    }
    [System.Obsolete]
    public void BlackB()
    {
        ball.color = new Color(0.2f, 0.2f, 0.2f);
    }
    [System.Obsolete]
    public void GreenB()
    {
        ball.color = Color.green;
    }
    [System.Obsolete]
    public void PurpleB()
    {
        ball.color = new Color(0.5607683f, 0.2272161f, 0.6981132f);
    }
    [System.Obsolete]
    public void GrayB()
    {
        ball.color = new Color(0.5f, 0.5f, 0.5f);
    }
    [System.Obsolete]
    public void OrangeB()
    {
        ball.color = new Color(1, 0.37f, 0);
    }
}
