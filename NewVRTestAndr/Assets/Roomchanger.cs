using UnityEngine;
using System.Collections;

public enum ROOMCHANGETYPE
{
	In,
	Out
}

public class Roomchanger : MonoBehaviour {

	public ROOMCHANGETYPE changeType;
	public static Vector3 PlayerPosition;

	public string SceneID = "";
	public string ScenePart = "";
	public string SceneType = "";

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") {
			PlayerPosition = c.gameObject.transform.position;

			switch (changeType) {
			case ROOMCHANGETYPE.In:
				SceneManaging.LoadScene (SceneID, ScenePart, SceneType);
				break;
			default:
				break;
			}
		}
	}
}
