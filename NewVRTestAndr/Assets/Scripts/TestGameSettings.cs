using UnityEngine;
using System.Collections;

public class TestGameSettings : MonoBehaviour {

	public bool newLevel = false;
	public float timer = 4.0f;

	public string SceneID = "";
	public string ScenePart = "";
	public string SceneType = "";

	// Use this for initialization
	void Start () {
		Resolution resolution = Screen.currentResolution;
		int resHeight = resolution.height;
		int resWidth = resolution.width;

		Screen.SetResolution ((int)(resWidth / 1.75), (int)(resHeight / 1.75), true);
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0) {
			SceneManaging.LoadScene (SceneID, ScenePart, SceneType);
		}
	}
}
