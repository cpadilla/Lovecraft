﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static WorldTile.Coord location;
	public WorldTile tile;
	public int X;
	public int Y;

	public static bool EnteringRoom = false;
	public static GoDirection LastStep;
    
	public float Speed = 5f;
	public static int Health;

	// Use this for initialization
	void Start () {
            location.X = 0;
            location.Y = 0;
			Health = 10;
	}
	
	// Update is called once per frame
	void Update () {
	    //print("Player is " + ((EnteringRoom) ? "" : "not ") +"entering Room");
	    X = location.X;
	    Y = location.Y;
		tile = World.TryGetTile(X,Y);
		GameObject[] walls = GameObject.FindGameObjectsWithTag("MainWall");
		for(int i=0; i<walls.Length; i++){
			Physics2D.IgnoreCollision(gameObject.collider2D,walls[i].collider2D);
		}
	    rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * Speed, 0.8f),
	                                           Mathf.Lerp(0, Input.GetAxis("Vertical") * Speed, 0.8f));
	}

	void OnTriggerEnter2D(Collider2D obj){
    	if (obj.tag == "Room") EnteringRoom = true;
	}
	void OnCollisionEnter2D(Collision2D obj){
		if(obj.gameObject.tag == "Enemy") Health--;
		if(obj.gameObject.tag == "Bullet") Health--;
	}
}
