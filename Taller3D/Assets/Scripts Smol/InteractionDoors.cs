using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDoors : MonoBehaviour, IInteractuable
{
    //[SerializeField]
    //private Animator doorAnimator;

    //[SerializeField]
    //private GameController controller;

    //[SerializeField]
    //private bool isMechanism = true;

    //private bool used = false;



    //void OnTriggerStay(Collider other)
    //{
    //    if (!used && other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
    //    {
    //        ActivarObjeto();
    //    }
    //}

    public void ActivarObjeto()
    {

        Debug.Log("AbrirPuerta");
        //    used = true;

    //    if (isMechanism)
    //        controller.OnMechanismActivated();

    //    if (doorAnimator != null)
    //        doorAnimator.SetTrigger("Open");
    }
}
