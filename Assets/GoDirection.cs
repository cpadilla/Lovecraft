using UnityEngine;
using System.Collections;

public class GoDirection : MonoBehaviour
{

    public bool enabled = true;
    public string Direction;
    public GameObject Tile;
    public bool entered = false;
    private Camera camera;
    private World world;
    private Map map;

    public WorldTile.Coord room
    {
        get
        {
            var a = transform.parent.gameObject;
            WorldTile b = a.transform.parent.gameObject.GetComponent<WorldTile>();
            return b.coord;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        // if the obj is the player and this trigger is enabled
        if (obj.tag == "Player" && enabled)
        {
            camera = Camera.main;
            world = camera.GetComponent<World>();
            map = GameObject.Find("Map").GetComponent<Map>();

            // Create new room if next room doesn't exist
            #region Create New Room
            WorldTile nextRoom = null;
            switch (Direction)
            {
                case "North":
                    //nextRoom = World.TryGetTile(Player.location.X, Player.location.Y + 1);
                    nextRoom = World.TryGetTile(room.X, room.Y + 1);
                    //if (nextRoom == null) CreateNewRoom(8 * Player.location.X, 6 * (Player.location.Y + 1));
                    if (nextRoom == null) CreateNewRoom(8 * room.X, 6 * (room.Y + 1));
                    break;
                case "East":
                    //nextRoom = World.TryGetTile(Player.location.X + 1, Player.location.Y);
                    nextRoom = World.TryGetTile(room.X + 1, room.Y);
                    //if (nextRoom == null) CreateNewRoom(8 * (Player.location.X + 1), 6 * Player.location.Y);
                    if (nextRoom == null) CreateNewRoom(8 * (room.X + 1), 6 * room.Y);
                    break;
                case "South":
                    //nextRoom = World.TryGetTile(Player.location.X, Player.location.Y - 1);
                    nextRoom = World.TryGetTile(room.X, room.Y - 1);
                    //if (nextRoom == null) CreateNewRoom(8 * Player.location.X, 6 * (Player.location.Y - 1));
                    if (nextRoom == null) CreateNewRoom(8 * room.X, 6 * (room.Y - 1));
                    break;
                case "West":
                    //nextRoom = World.TryGetTile(Player.location.X - 1, Player.location.Y);
                    nextRoom = World.TryGetTile(room.X - 1, room.Y);
                    //if (nextRoom == null) CreateNewRoom(8 * (Player.location.X - 1), 6 * Player.location.Y);
                    if (nextRoom == null) CreateNewRoom(8 * (room.X - 1), 6 * room.Y);
                    break;
            }
            #endregion

            // If player is leaving this room
            if (enabled &&
                Player.LastStep != null &&
                (Player.LastStep.room.X == room.X &&
                Player.LastStep.room.Y == room.Y) == false)
            {
                // player entering room
                switch (Direction)
                {
                    case "North":
                        Player.location.Y++;
                        break;
                    case "East":
                        Player.location.X++;
                        break;
                    case "South":
                        Player.location.Y--;
                        break;
                    case "West":
                        Player.location.X--;
                        break;
                }

                Player.LastStep = this;
            }
            // else if 2 steps in the same room
            else if (enabled &&
                Player.LastStep != null &&
                Player.LastStep.room.X == room.X &&
                Player.LastStep.room.Y == room.Y)
            {
                Player.LastStep.enabled = true;
            }

            // Last step is this
            Player.LastStep = this;

            // Disable trigger
            enabled = false;

            #region Old code
            // if new area
            //if (!entered && !Player.EnteringRoom)
            //{
                //entered = true;
                //Player.EnteringRoom = true;

                //print("Player exlored " + Direction + "!");


                //// move map
                //// Move stuff now!
                //newTilePref.transform.parent = map.transform;
                //GoDirection newTileDir;
                //WorldTile newTile;
                //switch (Direction)
                //{
                //    case "North":
                //        Player.location.Y++;
                //        newTilePref.transform.Translate(0, 6, 0);
                //        newTile = newTilePref.GetComponent<WorldTile>();
                //        newTileDir =  newTile.Down.GetComponent<GoDirection>();
                //        newTileDir.entered = true;
                //        //camera.transform.Translate(0, 6, 0);
                //        break;
                //    case "East":
                //        Player.location.X++;
                //        newTilePref.transform.Translate(8, 0, 0);
                //        newTile = newTilePref.GetComponent<WorldTile>();
                //        newTileDir =  newTile.Left.GetComponent<GoDirection>();
                //        newTileDir.entered = true;
                //        //camera.transform.Translate(8, 0, 0);
                //        break;
                //    case "South":
                //        Player.location.Y--;
                //        newTilePref.transform.Translate(0, 6, 0);
                //        newTile = newTilePref.GetComponent<WorldTile>();
                //        newTileDir =  newTile.Up.GetComponent<GoDirection>();
                //        newTileDir.entered = true;
                //        //camera.transform.Translate(0, 6, 0);
                //        break;
                //    case "West":
                //        Player.location.X--;
                //        newTilePref.transform.Translate(-8, 0, 0);
                //        newTile = newTilePref.GetComponent<WorldTile>();
                //        newTileDir =  newTile.Right.GetComponent<GoDirection>();
                //        newTileDir.entered = true;
                //        //camera.transform.Translate(-8, 0, 0);
                //        break;
                //}

            //}
            //else if (!Player.EnteringRoom)
            //{
            //    print("Player went " + Direction + "!");
            //    //camera.transform.Translate(-8, 0, 0);
            //    switch (Direction)
            //    {
            //        case "North":
            //            Player.location.Y++;
            //            break;
            //        case "East":
            //            Player.location.X++;
            //            break;
            //        case "South":
            //            Player.location.Y--;
            //            break;
            //        case "West":
            //            Player.location.X--;
            //            break;
            //    }
            //}
            #endregion
        }
    }

    GameObject CreateNewRoom(float x, float y)
    {
        print("New Room Created!");
        // make new tile
        Vector3 newTilePos = new Vector3(x, y, 0);
        GameObject newTilePref = (GameObject)Instantiate(Tile, newTilePos, camera.transform.rotation);
        WorldTile newwt = newTilePref.GetComponent<WorldTile>();
        World.gridMap.Add(newwt);
        return newTilePref;
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        //Player.EnteringRoom = false;
        if (Player.LastStep != null &&
            Player.LastStep.room.X == room.X &&
            Player.LastStep.room.Y == room.Y)
        {
            Player.LastStep.enabled = true;
            Player.LastStep = null;
        }
    }
}
