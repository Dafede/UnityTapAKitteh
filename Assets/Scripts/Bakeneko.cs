using UnityEngine;
using System.Collections;

public class Bakeneko : MonoBehaviour {

	private ulong score = 0;
	private uint actualScoreIncrement = 1;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"IncreaseScore");
		//Score : update with saved info
	}

	void IncreaseScore(Notification notification){
		score += actualScoreIncrement;
		Debug.Log ("Score: "+ score);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}