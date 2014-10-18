using UnityEngine;
using System.Collections;

public class GoWest : MonoBehaviour {

        public GameObject Tile;
        private bool entered = false;
        private Camera camera;
        private World world;
        private Map map;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

        void OnTriggerEnter2D(Collider2D obj)
        {
            if (obj.tag == "Player" && !entered)
            {
                print("Player went West!");
                camera = Camera.main;
                world = camera.GetComponent<World>();
                map = GameObject.Find("Map").GetComponent<Map>();


                // make new tile
                Vector3 newTilePos = new Vector3(camera.transform.position.x, camera.transform.position.y, 0);
                GameObject newTilePref = (GameObject) Instantiate(Tile, newTilePos, camera.transform.rotation);

                // move map
                // Move stuff now!
                newTilePref.transform.parent = map.transform;
                newTilePref.transform.Translate(-8, 0, 0);

                // move camera
                // need to keep track of coordinates to check if new tile collides with previously visited one
                camera.transform.Translate(-8, 0, 0);

                entered = true;

            }
        }
}
