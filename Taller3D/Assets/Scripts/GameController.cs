using UnityEngine;
public class GameController : MonoBehaviour
{
    public Animator finalDoorAnimator;
    public int mechanismsToOpen = 3;

    void Update()
    {
    }

    public void OnMechanismActivated()
    {
        GameManager.Instance.ActivateMechanism();
        if (GameManager.Instance.MechanismsActivated >= mechanismsToOpen)
        {
            finalDoorAnimator.SetTrigger("Open");
        }
    }
}