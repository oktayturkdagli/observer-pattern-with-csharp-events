using System;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> onDoorwayTriggerEnter;
    public event Action<int> onDoorwayTriggerExit;


    public void DoorwayTriggerEnter(int id)
    {
        if (onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter(id);
        }
    }

    public void DoorwayTriggerExit(int id)
    {
        if (onDoorwayTriggerExit != null)
        {
            onDoorwayTriggerExit(id);
        }
    }

    //Set this to private so it can't be accidentally assigned twice
    private Func<List<GameObject>> onRequestListOfDoors;
    public void SetOnRequestListOfDoors(Func<List<GameObject>> returnEvent)
    {
        onRequestListOfDoors = returnEvent;
    }

    public List<GameObject> GetOnRequestListOfDoors()
    {
        if (onRequestListOfDoors != null)
        {
            return onRequestListOfDoors();
        }

        return null;
    }

}
