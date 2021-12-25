using UnityEngine;
using System.Collections.Generic;
using System;

public class Door : MonoBehaviour
{
    //ADVANCED to call a function

    //List<GameObject> doors;

    //private void Start()
    //{
    //    CSharpEvents.current.SetOnRequestListOfDoors(() => DoorCount());
    //}

    //private void UpdateDoorCount(List<GameObject> tempdoors)
    //{
    //    doors = tempdoors;
    //}

    //private List<GameObject> DoorCount()
    //{
    //    doors = new List<GameObject>();
    //    int wallGroupCount = transform.childCount;

    //    for (int i = 0; i < wallGroupCount; i++)
    //    {
    //        int wallCount = transform.GetChild(i).childCount;
    //        for (int j = 0; j < wallCount; j++)
    //        {
    //            if (transform.GetChild(i).GetChild(j).gameObject.name.Equals("door"))
    //            {
    //                doors.Add(transform.GetChild(i).GetChild(j).gameObject);
    //            }
    //        }
    //    }

    //    return doors;
    //}
}