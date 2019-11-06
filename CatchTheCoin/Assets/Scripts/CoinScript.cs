using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject Coins;
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Coins",spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player 1")
        {
            other.GetComponent<Player>().points++;
            Destroy(gameObject);
        }
    }

    void SpawnCoin()
    {
        var newCoin = GameObject.Instantiate(Coins);
    }
}
