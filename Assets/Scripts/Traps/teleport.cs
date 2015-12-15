using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public Transform exit;
    static Transform last;
    public bool canTeleport;

	void OnTriggerEnter ( Collider other )
	{
        if (exit == last && canTeleport)
        {
            return;
        }
		TeleportToExit (other);
        canTeleport = false;
	}
	void OnTriggerExit ( )
	{
		last = null;
        canTeleport = true;
	}
	void TeleportToExit ( Collider other )
	{
		last = transform;
		other.transform.position = exit.transform.position;
	}
}
