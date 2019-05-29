using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public int heyo = 0;

    public void BtnReset()
    {
        
        if (heyo == 0)
        {
            SceneManager.LoadScene("2");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("2"));
        }

         else if (heyo == 1)
        {
            SceneManager.LoadScene("yeey");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("yeey"));
        }

         else if (heyo == 2)
        {
            SceneManager.LoadScene("the scene we are using");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("the scene we are using"));
        }

        else if (heyo == 3)
        {
            SceneManager.LoadScene("meletest1.0");
            Destroy(gameObject);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("meletest1.0"));
        }
    }
}
