using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField]
    private float speed = 7.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
    }
    
    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);


        if (transform.position.y < -4.2f)
        {

            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        if (transform.position.y > 4.2f)
        {

            transform.position = new Vector3(transform.position.x, 4.2f, 0);
        }

        if (transform.position.x < -8.2f)
        {

            transform.position = new Vector3(-8.2f, transform.position.y, 0);
        }

        if (transform.position.x > 8.2f)
        {

            transform.position = new Vector3(8.2f, transform.position.y, 0);
        }
    }
        
}

