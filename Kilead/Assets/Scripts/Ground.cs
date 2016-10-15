using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	public Material brokeMat;
	private int index;

	// Use this for initialization
	void Start () {
		index = 0;
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (index==0)
			{
				gameObject.GetComponent<Renderer>().material = brokeMat;
				gameObject.tag = "Untagged";
			}
			if (index==1)
			{
				Destroy(gameObject);
			}
		}
	}

	void OnCollisionExit (Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			index ++;
		}
	}
}
