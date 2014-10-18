using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class World : MonoBehaviour {

        //List<Plane> 
        public GameObject Tile;
        WorldTile start = new WorldTile();

	// Use this for initialization
	void Start () {
            GameObject startTile = (GameObject)Instantiate(Tile, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
