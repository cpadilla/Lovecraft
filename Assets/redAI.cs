using UnityEngine;
using System.Collections;

public class redAI : MonoBehaviour {
	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 2f;
	private WorldTile tile;
	private EnemySpawner Spawner;
	int x,y;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Player").transform;
		x = (int)(transform.position.x/8);
		y = (int)(transform.position.y/6);
		tile = World.TryGetTile(x,y);
		if(tile.GetComponentInChildren<EnemySpawner>() != null)
			Spawner = tile.GetComponentInChildren<EnemySpawner>();
		else
			Spawner = tile.GetComponent<EnemySpawner>();
		gameObject.transform.parent = Spawner.transform;
	}
	
	// Update is called once per frame
	void Update () {
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
