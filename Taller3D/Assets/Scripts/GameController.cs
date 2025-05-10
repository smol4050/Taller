using UnityEngine;

public class GameController : MonoBehaviour
{
    public void OnMechanismActivated()
    {
        GameManager.Instance.ActivateMechanism();
    }
}
