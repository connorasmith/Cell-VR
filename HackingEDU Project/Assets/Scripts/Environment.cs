﻿using UnityEngine;
using System.Collections;

public class Environment : MonoBehaviour {

	private Vector3 floatBox;
    public static Environment environment;
    
    void Awake() {
    
		environment = this;
	//	floatBox = GetComponent<BoxCollider>().size;
    
    }

	// Use this for initialization
	void Start () {

	
	}
	
	void OnTriggerExit(Collider other) {
	
	  Rigidbody otherRigid = other.GetComponent<Rigidbody>();
	  
	  Vector3 otherVector = otherRigid.velocity;
	  
	  otherVector = new Vector3 (-otherVector.x * Random.Range (1.5f, 2.5f),
	                             -otherVector.y * Random.Range (1.5f, 2.5f),
	                             -otherVector.z * Random.Range (1.5f, 2.5f));
	
	  otherRigid.AddForce (otherVector, ForceMode.Impulse);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public Vector3 getLocation() {
	
	  return this.transform.position;
	
	}
	
	public Vector3 getSize() {
	
	  return floatBox;
	  
	}
	
}