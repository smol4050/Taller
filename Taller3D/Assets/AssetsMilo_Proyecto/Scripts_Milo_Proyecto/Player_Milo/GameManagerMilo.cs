using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMilo : MonoBehaviour
{
    public static GameManagerMilo Instance { get; private set; }
    public int MechanismsActivated { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void ActivateMechanism()
    {
        MechanismsActivated++;
        //UIController.Instance.UpdateCount(MechanismsActivated);
    }


}
