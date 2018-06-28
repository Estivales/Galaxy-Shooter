using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

    private Rigidbody2D _rb2d;

    public float scrollSpeed = -1.5f;

    // Use this for initialization
    void Start () {
        _rb2d = GetComponent<Rigidbody2D>();

        _rb2d.velocity = new Vector2 (scrollSpeed,0);
    }
	
	// Update is called once per frame
	void Update () {
    }
}
