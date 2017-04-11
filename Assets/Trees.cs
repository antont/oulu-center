﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
	public GameObject speedTree, group;

	void Start ()
	{
//		print (group + " " + group.transform.childCount);
		for (int i = 0; i < group.transform.childCount; i += 3) {
//			print (i);
			Instantiate (speedTree, group.transform.GetChild (i).position, Quaternion.identity);
			Destroy (group.transform.GetChild (i).gameObject);
		}
	}
}