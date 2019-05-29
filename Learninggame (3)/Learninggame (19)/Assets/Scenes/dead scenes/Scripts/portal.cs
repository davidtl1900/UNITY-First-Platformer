using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision gameObjectInformation)
    {
        if(gameObjectInformation.gameObject.name == "player")
        {
            Debug.Log("it portld");
            SceneManager.LoadScene("2");
        }
       
        
    }
    
}
