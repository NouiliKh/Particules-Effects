using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject cube;

	// Use this for initialization
	void Start () {
        Instantiate(cube, transform.position, gameObject.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
