using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int point = 0;


    private void Start()
    {

    }

    void Update()
    {
        scoreText.text = ($"Score: {point}");
    }
}
