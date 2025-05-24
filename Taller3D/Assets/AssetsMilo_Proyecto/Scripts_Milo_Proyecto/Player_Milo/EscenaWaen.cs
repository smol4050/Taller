using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaWaen : MonoBehaviour
{
    public string nextSceneName; // Asigna el nombre de la escena en el Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
