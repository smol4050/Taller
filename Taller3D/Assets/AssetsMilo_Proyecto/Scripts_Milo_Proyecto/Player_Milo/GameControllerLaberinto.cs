using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControllerLaberinto : MonoBehaviour
{
    public GameObject puerta;
    public TextMeshProUGUI puntaje;

    void Start()
    {
        if (puntaje == null)
        {
            GameObject puntajeObj = GameObject.Find("PuntajeText");
            if (puntajeObj != null)
            {
                puntaje = puntajeObj.GetComponent<TextMeshProUGUI>();
            }
            else
            {
                Debug.LogError("No se encontró el objeto 'PuntajeText' en la escena.");
            }
        }

        if (GameManagerMilo.Instance == null)
        {
            Debug.LogError("GameManagerMilo.Instance es nulo. Asegúrate de que el GameManager esté presente en la escena.");
        }
    }

    void Update()
    {
        if (GameManagerMilo.Instance != null && puntaje != null)
        {
            puntaje.text = GameManagerMilo.Instance.MechanismsActivated.ToString();
            if (puerta != null)
            {
                puerta.SetActive(MecanismosCompletos());
            }
            else
            {
                Debug.LogWarning("La referencia a 'puerta' no está asignada.");
            }
        }
    }

    public void ActivarMecanismo()
    {
        if (GameManagerMilo.Instance != null)
        {
            GameManagerMilo.Instance.ActivateMechanism();
        }
        else
        {
            Debug.LogError("GameManagerMilo.Instance es nulo. No se puede activar el mecanismo.");
        }
    }

    public bool MecanismosCompletos()
    {
        return GameManagerMilo.Instance != null && GameManagerMilo.Instance.MechanismsActivated >= 4;
    }
}
