using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Manager : MonoBehaviour {

	public GameObject[] ground;
	public EndPoint endPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		ground = GameObject.FindGameObjectsWithTag("Ground");


		if (ground.Length == 0)
		{
			endPoint.mayFin = true;
		}
	}
}
