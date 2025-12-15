using UnityEngine;

public class IceSlot : MonoBehaviour
{
    [Header("Slot Settings")]
    public bool occupied = false;

    public void Occupy()
    {
        occupied = true;
    }
}
