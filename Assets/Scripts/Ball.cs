using System.Collections;
using System.Collections.Generic;
using UnityEngine.Scripting;
using UnityEngine;

public class Ball : MonoBehaviour {

    protected float jump_speed = 5.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(-7.0f, 6.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
	}

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
