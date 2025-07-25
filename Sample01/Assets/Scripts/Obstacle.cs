using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;
  

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("장애물 충돌!");
            obstacle.gameObject.SetActive(false);
            player.GetComponent<PlayerController>().speed--;
        }
    }
}


