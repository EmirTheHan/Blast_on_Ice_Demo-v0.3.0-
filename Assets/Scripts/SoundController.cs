using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource whistle, fan1, fan2;
    void Start()
    {
        whistle.PlayDelayed(5.5f);
        fan1.PlayDelayed(6.2f);
        fan2.PlayDelayed(6.2f);
    }
}
