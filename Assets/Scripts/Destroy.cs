using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    Vector3 Distance;

    private void Start()
    {
        Distance = transform.position - player.transform.position;
    }
    private void Update()
    {
        transform.position = player.transform.position + Distance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
