using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class player : MonoBehaviour {
    public float moveSpeed;
    
    public float speed = 10;
    // private GameObject endRotation;


    void Start()
    {
        moveSpeed = 2f;
        // endRotation = new GameObject();
    }

    void Update()
    {

        transform.Translate(0f,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);	

        if (Input.GetKey(KeyCode.A))
        transform.Rotate(-Vector3.up * speed * Time.deltaTime);
      
        if (Input.GetKey(KeyCode.D))
        transform.Rotate(Vector3.up * speed * Time.deltaTime);

  //       if (Input.GetKey("space")){
		//      transform.Rotate(Vector3.up * speed * Time.deltaTime);
		// }

        // this.transform.rotation = Quaternion.Lerp(this.transform.rotation, endRotation.transform.rotation, Time.deltaTime*speed);

    }
}
