using UnityEngine;
using System.Collections;

public class Move_Terrain : MonoBehaviour {

    
    public Transform Spawn;
    public GameObject Tile;

	// Use this for initialization
	void Start () {
        //this.transform.position = Spawn.position;
    }
    private float timer = 0;
    public float time_to_destroy;
    public float speed;
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        timer += Time.deltaTime;
        if(timer >= time_to_destroy)
        {
            Destroy(this.gameObject);
        }
    }
  //new Vector3(-34, 0, 0)  
}

