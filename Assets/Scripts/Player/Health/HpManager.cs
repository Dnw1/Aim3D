using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class  HpManager : MonoBehaviour {

	public static HpManager instance;
	public int playerHealth = 3;
	
	void Start()
    {
		instance = this;
	}
	void Update()
	{
		HealthManager ();
	}
	private void HealthManager()
	{
		if (playerHealth < 1 || playerHealth > 3) { //Check for either playerDeaths / Cheating.
			Application.LoadLevel ("Credits");
		}
	}
}
