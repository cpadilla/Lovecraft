using UnityEngine;
using System.Collections;

public class purpleAI : MonoBehaviour {
	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 2f;
	private WorldTile tile;
	int x,y;
	//int count=0;
	///Inizialization///
	void Start ()
	{
		x = (int)(transform.position.x);
		y = (int)(transform.position.y);
		target = GameObject.Find("Player").transform;
		tile = World.TryGetTile((int)(transform.position.x)/8,((int)(transform.position.y)/6));
		transform.parent = tile.transform;
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
}
