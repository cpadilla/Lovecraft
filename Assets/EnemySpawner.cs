using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject fast;
	public GameObject slow;
	public GameObject idiot;
	public GameObject shaman;
	public GameObject boss;

	// Use this for initialization
	void Start () {
		int Rand = Random.Range(0,99);
		Vector3 location = new Vector3(transform.position.x+Random.Range(-3,3),
		                               transform.position.y+Random.Range(-2,2),0);
		Quaternion rotation = transform.rotation;
		if(Rand < 40)
			Instantiate(idiot, location, rotation);
		else if(Rand < 70)
			Instantiate(slow, location, rotation);
		else if(Rand < 80)
			Instantiate(fast, location, rotation);
		else if(Rand < 90)
			Instantiate(shaman, location, rotation);
		else
			Instantiate(boss, location, rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
