using UnityEngine;
using System.Collections;

public class bossAI : MonoBehaviour {
	public GameObject bullet;
	public Transform target;
	public float speed = 1f;
	int count = 0;
	int period = 0;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
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
