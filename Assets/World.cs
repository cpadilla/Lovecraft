using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class World : MonoBehaviour {

        //List<Plane> 
        public GameObject currentTile;
        public static List<WorldTile> gridMap = new List<WorldTile>();
        //private GameObject player;

	// Use this for initialization
	void Start () {
            transform.position = new Vector3(0,0,0);
            currentTile = (GameObject)Instantiate(currentTile, transform.position, transform.rotation);
            WorldTile wtcurr = currentTile.GetComponent<WorldTile>();
            wtcurr.coord.X = 0;
            wtcurr.coord.Y = 0;
            gridMap.Add(wtcurr);
            Player.Health = 10;
            //player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
            //camera.transform.Translate(8 * Player.location.X, 6 * Player.location.Y, 0);
            camera.transform.position = new Vector3(8 * Player.location.X, 6 * Player.location.Y, -10);
            //print(string.Format("Player Location: {0} : {1}", Player.location.X, Player.location.Y));
            if (Player.Health <= 0)
            {
                //Reset();
            }
	}

        void Reset()
        {
            // Destroy All Tiles
            foreach(WorldTile w in gridMap)
            {
                Destroy(w.gameObject);
            }

            // Add new tile
            currentTile = (GameObject)Instantiate(currentTile, transform.position, transform.rotation);
            WorldTile AWholeNewWorld = currentTile.GetComponent<WorldTile>();
            AWholeNewWorld.coord.X = 0;
            AWholeNewWorld.coord.Y = 0;
            gridMap.Add(AWholeNewWorld);

            GameObject t = GameObject.Find("Inventory");
            Inventory inv = t.GetComponent<Inventory>();
            //for (bool item in inv.Inv)
            for (int i = 0; i < inv.Inv.Length; i++ )
            {
                inv.Inv[i] = false;
            }

            Player.Health = 10;
            Player.location.X = 0;
            Player.location.X = 0;

        }

        public static WorldTile TryGetTile(int x, int y)
        {
            try
            {
                foreach (WorldTile tile in gridMap)
                {
                    if (tile != null && tile.coord.X == x && tile.coord.Y == y)
                        return tile;
                }

            }
            catch (System.Exception)
            {
                return null;
            }

            return null;
        }

        /// <summary>
        /// Checks to see if the Player is entering this WorldTile
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public static bool IsPlayerEnteringThisRoom(GameObject room)
        {
            //if (room.GetComponent<WorldTile>().)
            return false;
        }

        void OnTriggerEnter2D(Collider2D obj)
        {
            //print("Hit");
        }
}
