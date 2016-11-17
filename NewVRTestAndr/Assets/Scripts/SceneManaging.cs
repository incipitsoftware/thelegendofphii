using UnityEngine;
using System.Collections;

public class SceneManaging : MonoBehaviour {

	public static string SceneToLoad = "";

	public string SceneID = "";
	public string ScenePart = "";
	public string SceneType = "";

	public bool onTrigger = false;

	private const string LoadingSceneID = "phii-loadingscene";

	public static void LoadScene(string sceneID, string part, string type)
	{
		//save scene to load into public and static string to call it in loading scene
		SceneToLoad = "phii-" + sceneID + "-" + part + "-" + type;

		//go to loading scene
		UnityEngine.SceneManagement.SceneManager.LoadScene(LoadingSceneID);
	}

	void OnTriggerEnter(Collider c)
	{
		if (onTrigger && c.tag == "Player") {
			SceneManaging.LoadScene (SceneID, ScenePart, SceneType);
		}
	}
}
