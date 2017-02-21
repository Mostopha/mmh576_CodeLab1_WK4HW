using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour {
    public Rigidbody2D rocket;
    public float speed = 10f;

    public KeyCode shootButton = KeyCode.LeftControl;

    // Use this for initialization
    void Start () {
		
	}

    void FireRocket()
    {
        Rigidbody2D rocketClone = (Rigidbody2D)Instantiate(rocket, transform.position, transform.rotation);
        rocketClone.AddForce (Vector3.right * speed);

        // You can also acccess other components / scripts of the clone
       
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(shootButton))
        {
            FireRocket();
        }
		
	}
}
