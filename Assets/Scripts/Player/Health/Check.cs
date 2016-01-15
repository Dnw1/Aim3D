using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Check : MonoBehaviour {
    
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player1" || col.gameObject.tag == "Player2")
		{
			Debug.Log("Triggered");
			HpManager.instance.playerHealth = HpManager.instance.playerHealth - 1;
		}
	}
}
