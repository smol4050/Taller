using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionsInterruptors : MonoBehaviour
{
    public AudioSource myAudio;
    public int interruptorActivado = 0;

    public void ActivarObjeto()
    {
        if (myAudio != null && myAudio.isPlaying)
        {
            myAudio.Stop();
        }

        interruptorActivado++;
        Debug.Log("Interruptor activado. Total: " + interruptorActivado);
    }
}
