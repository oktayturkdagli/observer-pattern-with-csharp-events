using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.current.DoorwayTriggerEnter(id);
        Debug.Log("Door Count: " + GameEvents.current.GetOnRequestListOfDoors().Count);
    }

    private void OnTriggerExit(Collider other)
    {
        GameEvents.current.DoorwayTriggerExit(id);
    }
}
