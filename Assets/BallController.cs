using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;

    public GameObject scoreText;
    private int score;


    // Use this for initialization
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("scoreText");

        score = 0;
        SetScore();
    }


    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;


        if (yourTag == "LargeStarTag")
        {
            score += 100;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 200;
        }

        SetScore();
    }

    void SetScore()
    {
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }
}
