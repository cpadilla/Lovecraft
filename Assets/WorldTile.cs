using UnityEngine;
using System.Collections;

public class WorldTile : MonoBehaviour {

        public WorldTile Up;
        public WorldTile Down;
        public WorldTile Left;
        public WorldTile Right;

	// Use this for initialization
	void Start () {
            transform.Translate(0, 0, 10);
            transform.Rotate(90, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
