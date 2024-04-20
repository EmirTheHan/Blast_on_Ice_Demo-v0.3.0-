using UnityEngine;

public class StartGame : MonoBehaviour
{
    public static bool game;
    private void Start()
    {
        game = false;
    }
    public void GameStarted()
    {
        game = true;
    }
}
