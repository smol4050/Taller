using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsDoorOpen = false;
    [SerializeField] private int requiredSwitchesToOpen = 1;

    [SerializeField] private SlideDoorManager slideDoorManager;

    private List<PressureSwitch> currentSwitchesOpen = new();

    public int CurrentSwitchesOpen => currentSwitchesOpen.Count;

    public void AddPressureSwitch(PressureSwitch currentSwitch)
    {
        if (!currentSwitchesOpen.Contains(currentSwitch))
        {
            currentSwitchesOpen.Add(currentSwitch);
        }
        TryOpen();
    }

    public void RemovePressureSwitch(PressureSwitch currentSwitch)
    {
        if (currentSwitchesOpen.Contains(currentSwitch))
        {
            currentSwitchesOpen.Remove(currentSwitch);
        }
        TryOpen();
    }
    private void TryOpen()
    {
        if (CurrentSwitchesOpen == requiredSwitchesToOpen)
        {
            OpenDoor();
        }
        else if (CurrentSwitchesOpen < requiredSwitchesToOpen)
        {
            CloseDoor();
        }
    }

    private void CloseDoor()
    {
        if (IsDoorOpen)
        {
            slideDoorManager.CloseDoors();

        }
        IsDoorOpen = false;

    }

    private void OpenDoor()
    {
        if (!IsDoorOpen)
        {
            slideDoorManager.OpenDoors();
        }
        IsDoorOpen = true;

    }
}

