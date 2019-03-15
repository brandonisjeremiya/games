using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
	GameObject monster;

    public void RedBtn ()
    {
    	monster = GameObject.Find("monster");
		//	print(GameObject.Find("monster").GetComponent<monster>().canWalk);
    	print(monster.GetComponent<monster>().canWalk);
    }
}
