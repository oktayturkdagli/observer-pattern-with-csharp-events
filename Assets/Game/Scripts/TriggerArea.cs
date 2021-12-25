using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        CSharpEventManager.current.OnWallTriggerEnter(id);

        //ADVANCED to call a function
        //Debug.Log("Door Count: " + GameEvents.current.GetOnRequestListOfDoors().Count);
    }

    private void OnTriggerExit(Collider other)
    {
        CSharpEventManager.current.OnWallTriggerExit(id);
    }
}