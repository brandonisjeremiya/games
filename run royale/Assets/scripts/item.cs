using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    float speed = 350.0f;

    void OnCollisionEnter(){
    	this.GetComponent<BoxCollider>().enabled = false;
    	this.GetComponent<MeshRenderer>().enabled = false;

    	Invoke("Respawn", 3);
    }

    void Respawn(){
    	this.GetComponent<BoxCollider>().enabled = true;
    	this.GetComponent<MeshRenderer>().enabled = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
