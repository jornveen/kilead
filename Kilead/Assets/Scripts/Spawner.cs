using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject ground;
	public GameObject groundUntagged;
	public GameObject groundStart;
	public GameObject groundEnd;
	public GameObject groundObstacal;

	public float withX;
	public float withZ;

	public float startX;
	public float startZ;

	public float changeObstacal;

	public int index;
	public Vector2[] posMayNotSpawn;

	void Start () {
		Instantiate(groundStart,Vector3.zero,Quaternion.identity);
		SpawnGround();
	}


	void Update () {
		
	}

	void SpawnGround () {

		for(int z = 0; z<withZ; z++)
		{
			for(int x = 0; x<withX; x++)
			{
				float procent = Random.Range(0,100);


				if (z>1&&z<withZ-2&&x>1&&x<withX-2&&procent<changeObstacal&&index==0&&posMayNotSpawn[0].x!=x&&posMayNotSpawn[1].y!=z)
				{
					Instantiate(groundUntagged,new Vector3(startX + x,0.5f,startZ -z),Quaternion.identity);
					posMayNotSpawn[0] = new Vector3(startX + x + 1f ,startZ -z + 1f);
					posMayNotSpawn[1] = new Vector3(startX + x + 1f ,startZ -z - 1f);
					index ++;
				}
				else
				{
					Instantiate(ground,new Vector3(startX + x,0,startZ -z),Quaternion.identity);
				}



				if (x==withX-1&&z==withZ-1)
				{
					int random = Mathf.RoundToInt(Random.Range(0,withX-1));
					Instantiate(groundEnd,new Vector3(startX + random,0,startZ -z -1),Quaternion.identity);
				}
			}
		}



	}
}
