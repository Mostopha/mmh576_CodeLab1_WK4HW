using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCollision : MonoBehaviour {
    public Collider2D player;
    public Collider2D box;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       Physics2D.IgnoreCollision(player, box);

	}
}
