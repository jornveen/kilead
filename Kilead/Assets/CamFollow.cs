using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {

	public Transform camRef;
	public float camSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp (transform.position, camRef.position, camSpeed);
	}
}
