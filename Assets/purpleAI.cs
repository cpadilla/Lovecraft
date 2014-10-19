using UnityEngine;
using System.Collections;

public class purpleAI : MonoBehaviour {
	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 2f;
	//private WorldTile tile;
	int x,y;
	//int count=0;
	///Inizialization///
	void Start ()
	{
		target = GameObject.Find("Player").transform;
		x = (int)(transform.position.x/8);
		y = (int)(transform.position.y/6);
		//tile = World.TryGetTile(x,y);
		//gameObject.transform.parent = tile.transform;
	}
	
	
	///Fixed Update///
	void Update ()
	{
		if(Player.location.X == x && Player.location.Y == y){
			Vector3 dir = target.position - transform.position;
			float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			if (Vector3.Distance(transform.position,target.position)>0.5f){
				transform.Translate(new Vector3(speed* Time.deltaTime,0,0));
			}
		}
	}
	void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.tag == "BulletPlayer"){
			Destroy(gameObject);
		}	
	}
}
