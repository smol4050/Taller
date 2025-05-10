using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsDoorOpen = false;
    [SerializeField] private int requiredSwitchesToOpen = 1;
    private List<PressureSwitch> currentSwitchesOpen = new();
    [SerializeField] SlideDoorManager slideDoorManager;

    void Start() {
        
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
