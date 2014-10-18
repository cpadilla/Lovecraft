using UnityEngine;
using System.Collections;

public class WorldTile : MonoBehaviour {

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
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
