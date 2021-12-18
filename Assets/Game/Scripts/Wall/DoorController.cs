using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;

    private void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayOpen(int id)
    {
        if (id == this.id)
        {
            transform.Translate(new Vector3(0, 1.6f, 0));
        }
    }

    private void OnDoorwayClose(int id)
    {
        if (id == this.id)
        {
            transform.Translate(new Vector3(0, -1.6f, 0));
        }
    }


    public void OnDestroy()
    {
        GameEvents.current.onDoorwayTriggerEnter -= OnDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit -= OnDoorwayClose;
    }
}
