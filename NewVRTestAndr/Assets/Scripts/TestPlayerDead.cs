using UnityEngine;
using System.Collections;

public class TestPlayerDead : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") {
			UnityEngine.SceneManagement.SceneManager.LoadScene (Application.loadedLevelName);
		}
	}
}
