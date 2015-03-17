using UnityEngine;
using System.Collections;

public class CatHandler : MonoBehaviour {

	public Sprite normalCat;
	public Sprite touchedCat;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		gameObject.GetComponent<SpriteRenderer> ().sprite = touchedCat;
		//NotificationCenter.DefaultCenter().PostNotification(this, "IncreaseScore", pointsToIncrement);
		NotificationCenter.DefaultCenter().PostNotification(this, "IncreaseScore");
	}

	void OnMouseUp() {
		gameObject.GetComponent<SpriteRenderer> ().sprite = normalCat;
	}
}
