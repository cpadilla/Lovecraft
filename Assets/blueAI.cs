﻿using UnityEngine;
using System.Collections;

public class blueAI : MonoBehaviour {
	public float speed = 2f;
	public float Distance = 10f;
	float Travel = 0;
	//private WorldTile tile;
	int x,y;
	//float rotate = 0;
	// Use this for initialization
	void Start () {
		x = (int)(transform.position.x/8);
		y = (int)(transform.position.y/6);
		//tile = World.TryGetTile(x,y);
		//gameObject.transform.parent = tile.transform;
	}
	// Update is called once per frame
	void Update (){
		if(Player.location.X == x && Player.location.Y == y){
			if(Travel > 30){
				Travel = 0;
				transform.Rotate(new Vector3(0,0,Random.Range(-180,180)));
			}
			Travel++;
			transform.Translate(new Vector3 (speed * Time.deltaTime, 0, 0));
		}
	}
	void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.tag == "BulletPlayer"){
			Destroy(gameObject);
		}	
	}
}
