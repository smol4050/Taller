using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControllerLaberinto : MonoBehaviour
{
    public GameObject puerta;
    public TextMeshProUGUI puntaje;

    // Llama al GameManager para activar un mecanismo
    public void ActivarMecanismo()
    {
        GameManagerMilo.Instance.ActivateMechanism();
    }

    // Retorna true si ya hay más de 4 mecanismos activados

    private void Update()
    {
        puerta.SetActive(MecanismosCompletos());
        puntaje.text = GameManagerMilo.Instance.MechanismsActivated.ToString();
    }

    public bool MecanismosCompletos()
    {
        return GameManagerMilo.Instance.MechanismsActivated >= 4;
    }
}
