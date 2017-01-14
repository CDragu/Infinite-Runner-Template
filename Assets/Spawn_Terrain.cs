using UnityEngine;
using System.Collections;

public class Spawn_Terrain : MonoBehaviour {

    public Transform Spawn;
    public GameObject Tile;
    // Use this for initialization
    void Start () {
	
	}
    private float timer = 0;
    public float time_to_respawn;
    
    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (timer >= time_to_respawn)
        {
            Instantiate(Tile, Spawn.position, Quaternion.identity);
            //Tile.transform.position = Spawn.position;
            timer = 0;
            //Debug.Log(this.transform.position);
        }

    }
}
