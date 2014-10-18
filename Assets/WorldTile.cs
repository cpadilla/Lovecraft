using UnityEngine;
using System.Collections;

public class WorldTile : MonoBehaviour {

        public WorldTile Up;
        public WorldTile Down;
        public WorldTile Left;
        public WorldTile Right;

	// Use this for initialization
	void Start () {
            transform.Rotate(90, 0, 0);
            transform.Translate(0, 10, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
