using UnityEngine;
using System.Collections;

public enum COLLECTIVETYPE
{
	Rupee1,
	Heart
};

public class Collective : MonoBehaviour {

	public COLLECTIVETYPE CollectiveType;

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") {
			switch (CollectiveType) {
			case COLLECTIVETYPE.Rupee1:
				LEVELSTATS.RUPEE_COUNT++;
				Destroy (this.gameObject);
				break;
			default:
				break;
			}
		}
	}
}
