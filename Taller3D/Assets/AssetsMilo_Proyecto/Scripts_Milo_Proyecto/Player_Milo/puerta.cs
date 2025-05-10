using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta : MonoBehaviour
{
    public string nombreEscenaDestino; // Asigna el nombre exacto de la escena en el Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que tu jugador tenga el tag "Player"
        {
            SceneManager.LoadScene(nombreEscenaDestino);
        }
    }
}
