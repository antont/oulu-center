using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
	public GameObject speedTree, group;

	void Start ()
	{
		for (int i = 0; i < group.transform.childCount; i += 3) {
			GameObject instance = Instantiate (speedTree, 
				                      group.transform.GetChild (i).position, 
				                      Quaternion.Euler (0, Random.Range (0, 360), 0), 
				                      transform);
			float random = Random.Range (.5f, 1f);
			instance.transform.localScale = new Vector3 (random, random, random);
			Destroy (group.transform.GetChild (i).gameObject);
		}
	}
}
