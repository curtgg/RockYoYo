using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour {

    bool isRoot = false;
    bool isTail = false;

    public GameObject prefab;
	// Use this for initialization
	void Start () {
        if(GameObject.FindGameObjectsWithTag("Rope").Length == 1)
        {
            this.isRoot = true;
         //  this.GetComponent<Transform>().SetParent(GameObject.FindGameObjectWithTag("Player").transform);

           
        }	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       // gameObject.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
