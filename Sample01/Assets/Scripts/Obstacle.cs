using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerController controller;


    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter(Collider other)
    {
        controller = GetComponent<PlayerController>();
        if (controller.gameObject.CompareTag("obstacle"))
        {
            controller.gameObject.SetActive(false);
            controller.speed--;
        }
    }
}


