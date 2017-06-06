using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectground : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosionground;
    public GameObject groundPound;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(explosion, transform.position, explosion.transform.rotation);
            Instantiate(explosionground, transform.position, explosion.transform.rotation);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(groundPound, transform.position, groundPound.transform.rotation);
    }

}


