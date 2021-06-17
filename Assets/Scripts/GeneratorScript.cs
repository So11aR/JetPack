using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    public GameObject Room1;
    public GameObject Room2;
    public GameObject Room3;

    public GameObject Coins1;
    public GameObject Coins2;
    public GameObject Coins3;

    public GameObject Laser;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int NumberOfRoom = Random.Range(0, 3);

            if (NumberOfRoom == 0)
            {
                Instantiate(Room1, new Vector2(transform.position.x + 28.8f, 0), Quaternion.identity);
            }
            if (NumberOfRoom == 1)
            {
                Instantiate(Room2, new Vector2(transform.position.x + 28.8f, 0), Quaternion.identity);
            }
            if (NumberOfRoom == 2)
            {
                Instantiate(Room3, new Vector2(transform.position.x + 28.8f, 0), Quaternion.identity);
            }

            int NumberOfCoins = Random.Range(0, 3);

            if (NumberOfCoins == 0)
            {
                Instantiate(Coins1, new Vector2(transform.position.x + Random.Range(20, 25), Random.Range(-2.3f,2.5f)), Quaternion.identity);
            }
            if (NumberOfCoins == 1)
            {
                Instantiate(Coins2, new Vector2(transform.position.x + Random.Range(20, 25), Random.Range(-2.3f, 2.5f)), Quaternion.identity);
            }
            if (NumberOfCoins == 2)
            {
                Instantiate(Coins3, new Vector2(transform.position.x + Random.Range(20, 25), Random.Range(-2.3f, 2.5f)), Quaternion.identity);
            }

            int NumberOfLasers   = Random.Range(0, 0);

            if (NumberOfLasers == 0)
            {
                Instantiate(Laser, new Vector2(transform.position.x + Random.Range(20, 25), Random.Range(-1f, 2f)), Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
