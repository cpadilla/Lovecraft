using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class World : MonoBehaviour {

        //List<Plane> 
        public GameObject startTile;

	// Use this for initialization
	void Start () {
            startTile = (GameObject)Instantiate(startTile, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
