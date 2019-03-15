using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 	public class step : MonoBehaviour {
     public AudioClip walkSound;
     public float footStepDelay;
 
     private float nextFootstep = 0;
 
     void Update () {
         if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S)
             || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W)) {
             nextFootstep -= Time.deltaTime;
             if (nextFootstep <= 0) {
                 GetComponent<AudioSource>().PlayOneShot(walkSound, 0.7f);
                 nextFootstep += footStepDelay;
             }
         }
     }
 }