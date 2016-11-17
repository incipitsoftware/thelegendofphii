using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public void LoadLevelI(int i)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(i);
	}

	public void LoadLevelI(string i)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(i);
	}
}
