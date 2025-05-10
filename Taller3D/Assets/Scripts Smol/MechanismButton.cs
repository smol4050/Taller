using UnityEngine;

public class MechanismButton : MonoBehaviour
{
    public GameController controller;
    private bool used = false;

    void OnTriggerStay(Collider other)
    {
        if (!used && other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            used = true;
            controller.OnMechanismActivated();
        }
    }
}
