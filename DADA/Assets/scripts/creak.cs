using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creak : MonoBehaviour {

	public AudioSource source;
	public AudioClip[] audioClipArray;

	public void Awake () {
		source = GetComponent<AudioSource>();
	}

   public void OnTriggerEnter(Collider other) {
   	if (other.CompareTag("player"))
    	{
   		source.clip=audioClipArray[Random.Range(0,audioClipArray.Length)];
   		source.PlayOneShot (source.clip);
   		}
   }
}
