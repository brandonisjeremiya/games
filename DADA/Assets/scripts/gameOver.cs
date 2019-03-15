﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    [SerializeField] private string loadLevel;

    void OnTriggerEnter(Collider other) 
    {
    	if(other.CompareTag("player"))
    	{
    		SceneManager.LoadScene(loadLevel);
    	}
    }
}