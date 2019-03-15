using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerMonster : MonoBehaviour {

	public Transform Spawnpoint;
	public Rigidbody Prefab;

    void OnTriggerEnter(Collider other) {
    	if (other.CompareTag("player"))
    	{
    	// print ("player hit trigger");
    	Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    	}
    }

}
