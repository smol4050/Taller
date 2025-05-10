using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionsInterruptors : MonoBehaviour, IInteractuable

{
    public AudioSource myAudio;
    GameControllerLaberinto gamecontro;

    void Start()
    {
        gamecontro = FindObjectOfType<GameControllerLaberinto>();
    }

    public void ActivarObjeto()
    {
        if (myAudio != null && myAudio.isPlaying)
        {
            myAudio.Stop();
        }

        gamecontro.ActivarMecanismo();
        Debug.Log("Interruptor activado. Total: ");
    }
}
