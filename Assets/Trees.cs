using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
	public GameObject speedTree;
	public GameObject[] sceneTreeGroups;

	void Start ()
	{
		foreach (GameObject sceneTreeGroup in sceneTreeGroups) {
			for (int i = 0; i < sceneTreeGroup.transform.childCount; i += 3) {
				GameObject instance = Instantiate (speedTree, 
					                      sceneTreeGroup.transform.GetChild (i).position, 
					                      Quaternion.Euler (0, Random.Range (0, 360), 0), 
					                      transform);
				float random = Random.Range (.5f, 1f);
				instance.transform.localScale = new Vector3 (random, random, random);
			}
			sceneTreeGroup.SetActive (false);
		}
	}
}
