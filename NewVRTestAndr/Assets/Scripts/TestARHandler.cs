using UnityEngine;
using System.Collections;

public class TestARHandler : MonoBehaviour {

	public GameObject ARCamera;
	public GameObject[] ActiveObjects;


	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") {
			ARCamera.SetActive (true);
			for (int i = 0; i <= ActiveObjects.Length; i++)
				ActiveObjects [i].SetActive (true);
		}
	}
}
