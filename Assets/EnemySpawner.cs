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
		seedEnemy();
		//Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void seedEnemy(){
		int Rand = Random.Range(0,99);
		Vector3 location = transform.position;
		Quaternion rotation = transform.rotation;
		if (Rand < 60 && Rand > 40)
			Instantiate(idiot, location, rotation);
		else if(Rand < 70 && Rand > 61)
			Instantiate(slow, location, rotation);
		else if(Rand < 80 && Rand > 71)
			Instantiate(fast, location, rotation);
		else if(Rand < 90 && Rand > 81)
			Instantiate(shaman, location, rotation);
		else if(Rand < 100 && Rand > 91)
			Instantiate(boss, location, rotation);

		Rand = Random.Range(0,99);
		if (Rand < 60 && Rand > 40)
			Instantiate(idiot, location, rotation);
		else if(Rand < 70 && Rand > 61)
			Instantiate(slow, location, rotation);
		else if(Rand < 80 && Rand > 71)
			Instantiate(fast, location, rotation);
		else if(Rand < 90 && Rand > 81)
			Instantiate(shaman, location, rotation);
		else if(Rand < 100 && Rand > 91)
			Instantiate(boss, location, rotation);

		Rand = Random.Range(0,99);
		if (Rand < 60 && Rand > 40)
			Instantiate(idiot, location, rotation);
		else if(Rand < 70 && Rand > 61)
			Instantiate(slow, location, rotation);
		else if(Rand < 80 && Rand > 71)
			Instantiate(fast, location, rotation);
		else if(Rand < 90 && Rand > 81)
			Instantiate(shaman, location, rotation);
		else if(Rand < 100 && Rand > 91)
			Instantiate(boss, location, rotation);
	}
}
