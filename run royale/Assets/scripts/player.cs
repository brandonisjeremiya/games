using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

	// movement
	public float moveSpeed;

	// jump
    public bool onGround;
    private Rigidbody rb;

    // slide
    

    // Start is called before the first frame update
    void Start()
    {
    	moveSpeed = 4f;
    	onGround = true;
    	rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    	// left, right and forward
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,7f*Time.deltaTime);

        // jump
        if(onGround) {
        	if(Input.GetButtonDown("Jump")){
        		rb.velocity = new Vector3(0f,4.5f,0f);
        		onGround = false;
        	}

        }

        // slide
		if (Input.GetKeyDown ("s")) {
			transform.localScale = new Vector3 (0.2946206f, 0.3f,0.3475012f);
		}
		if (Input.GetKeyUp ("s")) {
			transform.localScale = new Vector3 (0.2946206f, 0.9268705f,0.3475012f);
		}
    }

    // if grounded jump
    void OnCollisionEnter(Collision any) {
    	any.gameObject.CompareTag("Ground");
    	onGround = true;
    }
}
