using System;
using System.Collections.Generic;
using UnityEngine;

public class CSharpEventManager : MonoBehaviour
{
    public static CSharpEventManager current;

    private void Awake()
    {
        current = this;
    }

    //Events are created
    public event Action<int> onWallTriggerEnter;
    public event Action<int> onWallTriggerExit;

    //Events cannot be triggered directly from another class so they are triggered via functions
    public void OnWallTriggerEnter(int id)
    {
        onWallTriggerEnter?.Invoke(id);
    }

    public void OnWallTriggerExit(int id)
    {
        onWallTriggerExit?.Invoke(id);
    }

    //ADVANCED
    //To call a function
    //Set this to private so it can't be accidentally assigned twice
    //private Func<List<GameObject>> onRequestListOfDoors;
    //public void SetOnRequestListOfDoors(Func<List<GameObject>> returnEvent)
    //{
    //    onRequestListOfDoors = returnEvent;
    //}

    //public List<GameObject> GetOnRequestListOfDoors()
    //{
    //    if (onRequestListOfDoors != null)
    //    {
    //        return onRequestListOfDoors();
    //    }

    //    return null;
    //}

}