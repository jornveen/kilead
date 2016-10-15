using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Vector3 playerPos;
	public string curLevel;

	public float rayHitDist;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = transform.position;

		if (Input.GetButtonDown("Horizontal")&&transform.position.y==1&&!Input.GetButton("Vertical"))
		{
			if (!Physics.Raycast (transform.position, Vector3.forward,rayHitDist)&&Input.GetAxisRaw("Horizontal")==-1) 
			{
				playerPos.z -= Input.GetAxisRaw("Horizontal");
				transform.position = playerPos;
			}
			if (!Physics.Raycast (transform.position, Vector3.back,rayHitDist)&&Input.GetAxisRaw("Horizontal")==1) 
			{
				playerPos.z -= Input.GetAxisRaw("Horizontal");
				transform.position = playerPos;
			}
		}

		if (Input.GetButtonDown("Vertical")&&transform.position.y==1&&!Input.GetButton("Horizontal"))
		{
			if (!Physics.Raycast (transform.position, Vector3.right,rayHitDist)&&Input.GetAxisRaw("Vertical")==1) 
			{
				playerPos.x += Input.GetAxisRaw("Vertical");
				transform.position = playerPos;
			}
			if (!Physics.Raycast (transform.position, Vector3.left,rayHitDist)&&Input.GetAxisRaw("Vertical")==-1) 
			{
				playerPos.x += Input.GetAxisRaw("Vertical");
				transform.position = playerPos;
			}
		}



		if (transform.position.y <= -5)
		{
			Application.LoadLevel(curLevel);
		}
	}


}
