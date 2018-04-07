using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

  private GameObject ScoreText;

    int Point = 0;


	void Start () {
        this.ScoreText = GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update () {

       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SmallStarTag"))
        {
            this.Point += 10;
            this.ScoreText.GetComponent<Text>().text = ""+Point;
        } else if (other.gameObject.CompareTag("LargeStarTag"))
        {
            this.Point += 15;
            this.ScoreText.GetComponent<Text>().text = "" + Point;
        } else if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            this.Point += 20;
            this.ScoreText.GetComponent<Text>().text = "" + Point;
        } else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            this.Point += 25;
            this.ScoreText.GetComponent<Text>().text = "" + Point;
        }

    }
}
