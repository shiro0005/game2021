using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sceneseni: MonoBehaviour
{
    public string m_scene;
  
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Return))
            {

             
                SceneManager.LoadScene(m_scene);

            }
       
    }
}
