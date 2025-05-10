using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerLaberinto : MonoBehaviour
{
    // Llama al GameManager para activar un mecanismo
    public void ActivarMecanismo()
    {
        GameManager.Instance.ActivateMechanism();
    }

    // Retorna true si ya hay más de 4 mecanismos activados
    public bool MecanismosCompletos()
    {
        return GameManager.Instance.MechanismsActivated >= 4;
    }
}
