using UnityEngine;

public class Bakeneko : MonoBehaviour {

    public TextMesh scoreText;

	private ulong score = 0;
	private uint actualScoreIncrement = 1;


    public int numCincoBolsitas = 0;
    public int numCincuentaBolsitas = 0;
    public int numCienBolsitas = 0;
    public int numDosCienBolsitas = 0;
    public int numDosCienCincuentaBolsitas = 0;



	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"IncreaseScore");

        InvokeRepeating("UpdateScore", 1.0f, 1.0f);
		//Score : update with saved info
	}

	void IncreaseScore(Notification notification){
		score += actualScoreIncrement;
        scoreText.text = score.ToString();
		Debug.Log ("Score: "+ score);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void UpdateScore() { 
        int s = numCincoBolsitas * 5 + numCienBolsitas * 100 + numCincuentaBolsitas * 50 + numDosCienBolsitas * 200 + numDosCienCincuentaBolsitas * 250;
        score += (ulong)s;
        scoreText.text = score.ToString();
    }
}