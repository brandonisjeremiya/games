﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame ()
    {
    	SceneManager.LoadScene(1);
    }
    public void MainMenu ()
    {
    	SceneManager.LoadScene(0);
    }
}
