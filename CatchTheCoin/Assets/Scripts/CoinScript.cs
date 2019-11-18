using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject Coins;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player 1")
        {
            other.GetComponent<Player>().points++;
            Destroy(gameObject);
        }

        if (other.name == "Player 2")
        {
            other.GetComponent<Player>().points++;
            Destroy(gameObject);
        }
    }
}
