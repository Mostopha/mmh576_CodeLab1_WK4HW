using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;


public class gameManager : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public GameObject player1Text;
    public GameObject player2Text;

    public GameObject scoreText;

    private Text txt;

    private static int score;
    

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

        txt = scoreText.GetComponent<Text>();

        txt.text =" " +score;
      
    }
	
	// Update is called once per frame
	void Update () {

        txt.text = " " + score;

        if (player1 == null)
        {
            player2Text.SetActive(true);
            Invoke("Restart", 2);

            incrementScore = true;
            if(incrementScore == true)
            {
                score++;
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
                score--;
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
