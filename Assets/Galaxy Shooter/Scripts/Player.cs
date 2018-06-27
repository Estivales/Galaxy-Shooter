using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool canTripleShot = false;

    [SerializeField]
    public GameObject _laserPrefeb;
    [SerializeField]
    public GameObject _tripleShotPrefeb;

    [SerializeField]
    private float _speed = 7.0f;
    [SerializeField]
    private float _fireRate = 0.25f;
    private float _canFIre = 0.0f;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Movement();

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    

    private void Shoot()
    {
        if (Time.time > _canFIre)
        {

            if (canTripleShot)
            {
                Instantiate(_tripleShotPrefeb, new Vector3(transform.position.x - 0.25f, transform.position.y + 0.1f, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(_laserPrefeb, new Vector3(transform.position.x, transform.position.y + 0.88f, 0), Quaternion.identity);
            }

            _canFIre = Time.time + _fireRate;

          
        }
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * _speed * verticalInput);


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

