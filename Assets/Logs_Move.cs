using UnityEngine;
using System.Collections;

public class Logs_Move : MonoBehaviour {
    public Rigidbody Log;
    public float speed;
    public float Boiancy;
    
	// Use this for initialization
	void Start () {
	
	}
   
    // Update is called once per frame
    void Update () {
        

    }
    void FixedUpdate()
    {
        if (this.transform.position.y < 0.5)        
            Log.AddForce(Vector3.up * Boiancy);        
        if (this.transform.position.y > 0.5)
            Log.AddForce(Vector3.down * Boiancy);        
        if (this.transform.position.x < 0)
            Log.AddForce(speed, 0 , 0);
        if (this.transform.position.x > 0)
            Log.AddForce(-speed, 0, 0);
    }
}
