using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PMUI, QuitW, SettingsPanel, MenuW, Buttons, ResumeIcon, PrepMenu;
    public static bool isPaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (StartTimer.isStart || !StartGame.game))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        if (!StartGame.game)
        {
            PrepMenu.SetActive(true);
        }
        PMUI.SetActive(false);
        ResumeIcon.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause()
    {
        if (!StartGame.game)
        {
            PrepMenu.SetActive(false);
        }
        PMUI.SetActive(true);
        ResumeIcon.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void LoadSettings()
    {
        SettingsPanel.SetActive(true);
        Buttons.SetActive(false);
    }
    public void MenuWarning()
    {
        MenuW.SetActive(true);
        Buttons.SetActive(false);
    }
    public void ReturnMenu()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void QuitWarning()
    {
        QuitW.SetActive(true);
        Buttons.SetActive(false);
    }
    public void QtoP()
    {
        QuitW.SetActive(false);
        Buttons.SetActive(true);
    }    
    public void MtoP()
    {
        MenuW.SetActive(false);
        Buttons.SetActive(true);
    }     
    public void StoP()
    {
        SettingsPanel.SetActive(false);
        Buttons.SetActive(true);
    }    
    public void QuitGame()
    {
        Application.Quit();
    }
}
