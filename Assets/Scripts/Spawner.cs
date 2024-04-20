using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private bool _spawnP1 = false;
    private bool _spawnP2 = false;
    private bool _spawnBall = false;

    public static float p1_spawnTime;
    public static float p2_spawnTime;

    public GameObject P1, P2, Ball;
    public GameObject P1_rotation, P1_skillImage;
    public GameObject P2_rotation, P2_skillImage;

    Vector3 P1StartPosition = new(-13.5f, 7, 0);
    Vector3 P2StartPosition = new(13.5f, 7, 0);
    Vector3 BallStartPosition = new(0, 9, 0);

    private void Start()
    {
        p1_spawnTime = 6;
        p2_spawnTime = 6;
    }
    public bool isSpawnP1
    {
        get { return _spawnP1; }
        set
        {
            _spawnP1 = value;
            if (_spawnP1)
            {
                Invoke("SpawnP1", p1_spawnTime);
            }
        }
    }
    public bool isSpawnP2
    {
        get { return _spawnP2; }
        set
        {
            _spawnP2 = value;
            if (_spawnP2)
            {
                Invoke("SpawnP2", p2_spawnTime);
            }
        }
    }
    public bool isSpawnBall
    {
        get { return _spawnBall; }
        set
        {
            _spawnBall = value;
            if (_spawnBall)
            {
                Invoke("SpawnBall", 4);
            }
        }
    }
    public void SpawnP1()
    {
        P1.transform.SetPositionAndRotation(P1StartPosition, P1_rotation.transform.rotation);
        P1.SetActive(true);
        P1_skillImage.SetActive(true);
    }
    public void SpawnP2()
    {
        P2.transform.SetPositionAndRotation(P2StartPosition, P2_rotation.transform.rotation);
        P2.SetActive(true);
        P2_skillImage.SetActive(true);
    }
    public void SpawnBall()
    {
        BallManager.owner = 0;
        Ball.GetComponent<Rigidbody>().Sleep();
        Ball.transform.position = BallStartPosition;
        Ball.SetActive(true);
    }


}
