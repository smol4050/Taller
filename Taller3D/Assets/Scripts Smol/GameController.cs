using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Animator finalDoorAnimator;

    [SerializeField]
    private int mechanismsToOpen = 3;

    public void OnMechanismActivated()
    {
        GameManager.Instance.ActivateMechanism();
        if (GameManager.Instance.MechanismsActivated >= mechanismsToOpen)
        {
            finalDoorAnimator.SetTrigger("Open");
        }
    }
}
