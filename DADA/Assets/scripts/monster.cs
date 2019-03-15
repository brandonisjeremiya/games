using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;

public class monster : MonoBehaviour
{
    // public Button redBtn;

    public float moveSpeed;

    // [SerializeField] private string loadLevel;
   
    void Start()
    {
        moveSpeed = 5f;
        // redBtn.onClick.AddListener(() => ButtonClicked(42));
    }

    void Update()
    {
        transform.Translate(-moveSpeed*Time.deltaTime,0f,0f);
    }

    // void ButtonClicked(int redBtn)
    // {
    //     //Output this to console when the Button3 is clicked
    //     Debug.Log("Button clicked = " + redBtn);
    // }

    // void OnTriggerEnter(Collider other) 
    // {
    // 	if(other.CompareTag("player"))
    // 	{
    // 		SceneManager.LoadScene(loadLevel);
    // 	}
    // }
}
