using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Vector3 thrust;
    public Quaternion heading;
	// Use this for initialization
	void Start () {
        thrust.x = 400.0f;
        GetComponent<Rigidbody>().drag = 0;
        GetComponent<Rigidbody>().MoveRotation(heading);
        GetComponent<Rigidbody>().AddRelativeForce(thrust);
	}
	
    void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.collider;
        if(collider.CompareTag("Asteroid"))
        {
            Asteroid roid = collider.gameObject.GetComponent<Asteroid>();
            roid.Die();
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Collided with" + collider.tag);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
