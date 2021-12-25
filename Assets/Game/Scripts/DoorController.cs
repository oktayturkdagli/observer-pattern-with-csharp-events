using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;

    private void Start()
    {
        //Subscribe to events
        //Functions that will run when events are triggered are determined
        CSharpEventManager.current.onWallTriggerEnter += DoorOpen;
        CSharpEventManager.current.onWallTriggerExit += DoorClose;
    }

    private void DoorOpen(int id)
    {
        if (id == this.id)
        {
            transform.Translate(new Vector3(0, 1.6f, 0));
        }
    }

    private void DoorClose(int id)
    {
        if (id == this.id)
        {
            transform.Translate(new Vector3(0, -1.6f, 0));
        }
    }

    public void OnDestroy()
    {
        //Unsubscribe to events
        CSharpEventManager.current.onWallTriggerEnter -= DoorOpen;
        CSharpEventManager.current.onWallTriggerExit -= DoorClose;
    }
}