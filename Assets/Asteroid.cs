using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public int posintValue;
	// Use this for initialization
	void Start () {
        posintValue = 10;
	}
    public GameObject deathExplosion;
    public AudioClip deathKnell;
	public void Die() {
        AudioSource.PlayClipAtPoint(deathKnell,gameObject.transform.position);
        Instantiate(deathExplosion, gameObject.transform.position, Quaternion.AngleAxis(-90, Vector3.right));
        GameObject obj = GameObject.Find("GlobalObject");
        Global g = obj.GetComponent<Global>();
        g.score += posintValue;
        Destroy(gameObject);
        }
	// Update is called once per frame
	void Update () {
		
	}
}
