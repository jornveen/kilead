using UnityEngine;
using System.Collections;

public class EndPoint : MonoBehaviour {

	public bool mayFin;
	public string nextLevel;

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player"&&mayFin==true)
		{
			Application.LoadLevel(nextLevel);
		}
	}
}
