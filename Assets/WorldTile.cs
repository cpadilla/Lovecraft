using UnityEngine;
using System.Collections;

public class WorldTile : MonoBehaviour {
		public GameObject spawner;
        public struct Coord
        {
            public int X;
            public int Y;
        }

        public Coord coord;

        public GameObject Up;
        public GameObject Down;
        public GameObject Left;
        public GameObject Right;

        private GameObject WorldMap; 

	// Use this for initialization
	void Start () {
	    WorldMap = GameObject.Find("Map");
	    transform.parent = WorldMap.transform;
		SeedTile();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void SeedTile(){
		int Rand = Random.Range(0,99);
		if(Rand < 25){
			Vector3 location = transform.position;
			Quaternion rotation = Quaternion.LookRotation(Vector3.zero);
			//spawn clue spawner
		}
		Rand = Random.Range(0,99);
		if(Rand < 50){
			Vector3 location = transform.position;
			Quaternion rotation = Quaternion.LookRotation(Vector3.zero);
			Instantiate(spawner,location,rotation);
		}
		Rand = Random.Range(0,99);
		if(Rand < 50){
			Vector3 location = transform.position;
			Quaternion rotation = Quaternion.LookRotation(Vector3.zero);
			Instantiate(spawner,location,rotation);
		}
		Rand = Random.Range(0,99);
		if(Rand < 50){
			Vector3 location = transform.position;
			Quaternion rotation = Quaternion.LookRotation(Vector3.zero);
			Instantiate(spawner,location,rotation);
		}
	}
}
