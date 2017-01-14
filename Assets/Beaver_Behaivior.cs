using UnityEngine;
using System.Collections;

public class Beaver_Behaivior : MonoBehaviour {
    RaycastHit hit;
    public float raylenght = 1000;
    public  int layerMask = 1 << 8;// 1 << 8 means only layer 8
    // Use this for initialization
    void Start () {
        layerMask = ~layerMask;
    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, raylenght, layerMask))//use mask layer to make ray ignore the layer 8, 1 << 8 means only layer 8 but we inverse it with "~"
        {
            Connect(hit.collider.gameObject);
            Debug.Log(hit.collider.name);
        }
        Debug.DrawRay(ray.origin, ray.direction * raylenght, Color.red);
	}

    void Connect(GameObject connectedto)
    {
        Destroy(this.GetComponent<FixedJoint>());
        this.transform.position = new Vector3(connectedto.transform.position.x, connectedto.transform.position.y, connectedto.transform.position.z);//needs to be replaced with jump 
        //Jump(connectedto);
        var joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = connectedto.GetComponent<Rigidbody>();
    }
    void Jump(GameObject target)
    {

    }
}
