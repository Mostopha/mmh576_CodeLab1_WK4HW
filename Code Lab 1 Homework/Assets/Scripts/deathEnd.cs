using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathEnd : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(player1 == null)
        {

        }
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        Destroy(collider.gameObject);
    }
}
