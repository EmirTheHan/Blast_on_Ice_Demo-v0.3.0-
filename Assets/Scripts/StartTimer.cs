using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{
    public static bool isStart;
    private float t = 5.9f;
    public Text tN;
    public AudioSource countdown;
    public GameObject tD,fps, esc;
    void Start()
    {
        isStart = false;
        tN.text = "" + (int)t;
        countdown.Play();
    }
    void Update()
    {
        Invoke("CountDown",.2f);
    }
    public void CountDown()
    {
        if (t >= 0)
        {
            t -= Time.deltaTime;
            tN.text = "" + (int)t;
        }
        if (t < 0)
        {
            isStart = true;
            tD.SetActive(false);
            fps.SetActive(true);
            esc.SetActive(true);
        }
    }
}
