using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class World : MonoBehaviour {

        //List<Plane> 
        public GameObject currentTile;
        private GameObject player;

	// Use this for initialization
	void Start () {
            currentTile = (GameObject)Instantiate(currentTile, transform.position, transform.rotation);
            player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
            //print("player X:      " + player.transform.position.x);
            //print("player Y: " + player.transform.position.y);
            //print("player Z: " + player.transform.position.z);
            //print("currentTile X: " + currentTile.transform.position.x);
            
	}

        void OnTriggerEnter2D(Collider2D obj)
        {
            print("Hit");
        }
}
