using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItem : MonoBehaviour
{

	public GameObject item;
	int spawnNum = 1;

	void spawn (){
		for (int i = 0; i < spawnNum; i++)
		{
			Vector3 itemPos = new Vector3(this.transform.position.x,
											this.transform.position.y,
											this.transform.position.z);
			Instantiate(item, itemPos, Quaternion.identity);
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
