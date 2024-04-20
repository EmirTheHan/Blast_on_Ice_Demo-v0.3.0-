using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FpsDisplay : MonoBehaviour
{
    private float fps;
    public Text d;
    void Start()
    {
        StartCoroutine(Getfps());
    }
    IEnumerator Getfps()
    {
        while (true)
        {
            fps = (int)(1 / Time.deltaTime);
            d.text = "FPS: " + fps;
            yield return new WaitForSeconds(1);
        }
    }
}
