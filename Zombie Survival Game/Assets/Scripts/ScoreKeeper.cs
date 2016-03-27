using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public ulong score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ulong timePassed = (ulong)GameObject.Find("TimeKeeper").GetComponent<Timer>().timer;
        score += timePassed;
        GameObject.Find("Score").GetComponent<Text>().text = "Score: " + score;
	}
}
