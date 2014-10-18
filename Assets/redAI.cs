using UnityEngine;
using System.Collections;

public class redAI : MonoBehaviour {
	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = target.position - transform.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		if (Vector3.Distance(transform.position,target.position)>0.5f){
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0));
		}
	}
}
