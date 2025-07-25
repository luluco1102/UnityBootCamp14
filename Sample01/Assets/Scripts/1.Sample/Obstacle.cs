using System;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            Debug.Log(other);
            obstacle.gameObject.SetActive(false);
            player.GetComponent<PlayerController>().speed -= 1;
        }

    }

}


