using UnityEngine;
using System.Collections;

public class CameraMovieHandle : MonoBehaviour {

	public string LoadSceneID;
	public string LoadScenePart;
	public string LoadSceneType;

	private Animation animation;
	private AnimationClip animClip;
	public float clipLength = 40.0f;

	void Start()
	{
		//animClip = GetComponent<Animation> ().clip;
		//clipLength = animClip.length;
	}

	void Update()
	{
		clipLength -= Time.deltaTime;
		//when animation ends, load new scene
		if (clipLength < 0) {
			//fade out
			//---
			//

			SceneManaging.LoadScene (LoadSceneID, LoadScenePart, LoadSceneType);
		}
	}
}
