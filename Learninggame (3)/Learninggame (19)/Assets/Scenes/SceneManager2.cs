﻿using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour
{
    public int hey = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if (hey == 0)
        {
            SceneManager.LoadScene("the scene we are using");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("the scene we are using"));
        }
        if (hey == 1)
        {
            SceneManager.LoadScene("yeey");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("yeey"));
        }
        if (hey == 2)
        {
            SceneManager.LoadScene("demoend");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("demoend"));
        }




    }


}

