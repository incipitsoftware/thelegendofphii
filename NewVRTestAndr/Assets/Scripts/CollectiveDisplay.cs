using UnityEngine;
using System.Collections;

public class CollectiveDisplay : MonoBehaviour {

	public COLLECTIVETYPE typeC;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		switch (typeC) {
		case COLLECTIVETYPE.Rupee1:
			gameObject.GetComponent<UnityEngine.UI.Text> ().text = LEVELSTATS.RUPEE_COUNT.ToString ();
			break;
		default:
			break;
		}
	}
}
