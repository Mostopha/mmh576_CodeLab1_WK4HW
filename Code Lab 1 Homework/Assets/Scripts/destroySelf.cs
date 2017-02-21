using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySelf : MonoBehaviour {
    public GameObject bullet;
    public float destroyDelay;

	// Use this for initialization
	void Start () {

        Invoke("Destroy", destroyDelay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Destroy()
    {
        Destroy(bullet);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Invoke("Destory", destroyDelay);
        Destroy();
    }
}
