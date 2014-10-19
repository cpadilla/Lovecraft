using UnityEngine;
using System.Collections;

public class bossAI : MonoBehaviour {
	public GameObject bullet;
	public Transform target;
	public float speed = 1f;
	int count = 0;
	int period = 0;
	private WorldTile tile;
	private EnemySpawner Spawner;
	int x,y;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Player").transform;
		tile = World.TryGetTile((int)(transform.position.x)/8,((int)(transform.position.y)/6));
		Spawner = tile.GetComponent<EnemySpawner>();
		transform.parent = Spawner.transform;
		x = (int)(transform.parent.position.x/8);
		y = (int)(transform.parent.position.y/6);
		print (x+" "+y);
	}
	
	// Update is called once per frame
	void Update () {
		print(x+" "+Player.location.X+" "+y+" "+Player.location.Y);
		if(Player.location.X == x && Player.location.Y == y){
			Vector3 dir = target.position - transform.position;
			float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			if (Vector3.Distance(transform.position,target.position)>0.5f){
				transform.Translate(new Vector3(speed* Time.deltaTime,0,0));
			}
			count = GameObject.FindGameObjectsWithTag("Bullet").Length;
			if(count < 5 && period >100){
				period = 0;
				Vector3 temp = transform.position;
				Instantiate(bullet, temp, transform.rotation);
				bullet.rigidbody2D.AddForce(new Vector2(Mathf.Lerp(10, 10, 0.8f), Mathf.Lerp(0, 1, 0.8f)));
			}
			period++;
		}
	}
}
