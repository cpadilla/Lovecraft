using UnityEngine;
using System.Collections;

public class BulletPlayer : MonoBehaviour {
	float speed = .05f;
	float SecondsUntilDestroy = 2;
	float startTime;
	// Use this for initialization
	void Start () {
		gameObject.tag = "BulletPlayer";
		startTime = Time.time; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += speed * transform.up;
		//transform.Translate(new Vector3(speed* Time.deltaTime,0,0));
		if (Time.time - startTime >= SecondsUntilDestroy) {
			Destroy(this.gameObject);
		} 
	}
	void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.tag == "Enemy")	Destroy(this.gameObject);
	}
}
