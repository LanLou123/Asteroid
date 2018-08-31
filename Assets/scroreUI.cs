using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroreUI : MonoBehaviour {
    Global globalObj;
    public Text mytext;
	// Use this for initialization
	void Start () {
        GameObject g = GameObject.Find("GlobalObject");
        globalObj = g.GetComponent<Global>();
        mytext = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        mytext.text = "current score : "+globalObj.score.ToString();
	}
}
