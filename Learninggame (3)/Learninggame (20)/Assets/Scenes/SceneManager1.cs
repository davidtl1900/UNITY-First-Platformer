using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
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
            SceneManager.LoadScene("meletest1.0");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("meletest1.0"));
        }
    }
}

