using System.Collections;
using UnityEngine;

public class Token_Spawner : MonoBehaviour
{
    private GameObject Token = null, SpawnEffect = null;
    public GameObject[] SpawnEffects;
    public GameObject[] Tokens;
    private bool _tokenTime;
    Renderer _renderer;
    Collider _collider;
    Vector3 randomPosition;
    float randomX, randomZ;
    int randomIndex;
    public bool TokenTime
    {
        get { return _tokenTime; }
        set
        {
            StartCoroutine(SpawnToken());
        }
    }
    IEnumerator SpawnToken()
    {
        while (!EndGame.Gameover && (GoalControl1.puan1 + GoalControl2.puan2) % 2 != 0)
        {
            yield return new WaitForSeconds(0.1f);

            randomIndex = Random.Range(0, Tokens.Length);
            Token = Tokens[randomIndex];
            _renderer = Token.GetComponent<Renderer>();

            if (!_renderer.enabled || !Token.activeSelf)
            {
                yield return new WaitForSeconds(14.1f); //14

                randomX = Random.Range(-5.5f, 5.5f);
                randomZ = Random.Range(-11f, 11f);
                randomPosition = new Vector3(randomX, 1.5f, randomZ);

                SpawnEffect = SpawnEffects[randomIndex];
                Instantiate(SpawnEffect, randomPosition, transform.rotation);

                yield return new WaitForSeconds(0.8f);

                _collider = Token.GetComponent<Collider>();
                Token.transform.position = randomPosition;
                foreach (Transform child in Token.transform)
                {
                    child.gameObject.GetComponent<Renderer>().enabled = true;
                }
                _renderer.enabled = true;
                _collider.enabled = true;

                Token.SetActive(true);
            }
        }
    }
    public void RemoveTokens() {
        foreach (var token in Tokens)
        {
            token.SetActive(false);
        }
    }
}
