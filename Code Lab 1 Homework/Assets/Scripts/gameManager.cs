using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;


public class gameManager : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public GameObject player1Text;
    public GameObject player2Text;

    public GameObject playerOneScoreText;
    public GameObject playerTwoScoreText;

    private Text txt1;
    private Text txt2;

    private static int playerOneScore;
    private static int playerTwoScore;


    public static gameManager instance;

    private bool incrementScore = false;

	// Use this for initialization
	void Start () {
        player2Text.SetActive(false);
        player1Text.SetActive(false);

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        txt1 = playerOneScoreText.GetComponent<Text>();
        txt2 = playerTwoScoreText.GetComponent<Text>();

        txt1.text ="P1: "+playerOneScore;
        txt2.text = "P2: " + playerTwoScore;

    }
	
	// Update is called once per frame
	void Update () {

        txt1.text = "P1 " + playerOneScore;
        txt2.text = "P2 " + playerTwoScore;

        if (player1 == null)
        {
            player2Text.SetActive(true);
            Invoke("Restart", 2);

            incrementScore = true;
            if(incrementScore == true)
            {
                playerOneScore++;
                incrementScore = false;
            }
            

        }
        else if(player2 == null)
        {
            player1Text.SetActive(true);
            Invoke("Restart", 2);

            incrementScore = true;
            if (incrementScore == true)
            {
                playerTwoScore++;
                incrementScore = false;
            }
        }


	}

    void Restart()
    {

        Scene grief = SceneManager.GetActiveScene();
        SceneManager.LoadScene("level2");

    }
}
