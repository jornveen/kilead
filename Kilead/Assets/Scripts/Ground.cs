using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	public Material[] brokeMat;
	private int index;

	// Use this for initialization
	void Start () {
		index = brokeMat.Length;
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (index==0)
			{
                Destroy(gameObject);
			}
            else if (index==1)
			{
                gameObject.GetComponent<Renderer>().material = brokeMat[index - 1];
                gameObject.tag = "Untagged";
            }
            else
            {
                gameObject.GetComponent<Renderer>().material = brokeMat[index - 1];
            }
        }
	}

	void OnCollisionExit (Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			index --;
		}
	}
}
