using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SceneChange(int s_no)
    {
        SceneManager.LoadScene(s_no);
    }   
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Oyundan Çıkıldı");
    }
}
