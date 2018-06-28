using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {
    [SerializeField]
    private float _speed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.canTripleShot = true;
            Destroy(this.gameObject);
        }
        
   
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

	}
}
