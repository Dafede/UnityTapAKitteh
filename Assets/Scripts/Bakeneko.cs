using UnityEngine;

public class Bakeneko : MonoBehaviour {

    public TextMesh scoreText;


    /* General information about the state of the game */
    private ulong actualScore = 0;
    private ulong maxScore = 0;
    private int numCincoBolsitas = 0;
    private int numCincuentaBolsitas = 0;
    private int numCienBolsitas = 0;
    private int numDosCienBolsitas = 0;
    private int numDosCienCincuentaBolsitas = 0;
    private int touchIncrement = 1;

    /* Properties */
    public ulong ActualScore
    {
        get { return actualScore; }
        set { actualScore = value; }
    }
    
    public ulong MaxScore
    {
        get { return maxScore; }
        set { maxScore = value; }
    }
    
    public int NumCincoBolsitas
    {
        get { return numCincoBolsitas; }
        set { numCincoBolsitas = value; }
    }

    public int NumCincuentaBolsitas
    {
        get { return numCincuentaBolsitas; }
        set { numCincuentaBolsitas = value; }
    }
    
    public int NumCienBolsitas
    {
        get { return numCienBolsitas; }
        set { numCienBolsitas = value; }
    }

    public int NumDosCienBolsitas
    {
        get { return numDosCienBolsitas; }
        set { numDosCienBolsitas = value; }
    }
    
    public int NumDosCienCincuentaBolsitas
    {
        get { return numDosCienCincuentaBolsitas; }
        set { numDosCienCincuentaBolsitas = value; }
    }

    public int TouchIncrement
    {
        get { return touchIncrement; }
        set { touchIncrement = value; }
    }



	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncreaseScoreTouch");

        InvokeRepeating("UpdateScore", 1.0f, 1.0f);
		//Load Store Info
	}

	void IncreaseScoreTouch(Notification notification){
        actualScore += (uint)touchIncrement;
        maxScore += (uint)touchIncrement;
        scoreText.text = actualScore.ToString();
        Debug.Log("Score: " + actualScore);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void UpdateScore() { 
        int s = numCincoBolsitas * 5 + numCienBolsitas * 100 + numCincuentaBolsitas * 50 + numDosCienBolsitas * 200 + numDosCienCincuentaBolsitas * 250;
        actualScore += (ulong)s;
        maxScore += (ulong)s;
        scoreText.text = actualScore.ToString();
    }
}