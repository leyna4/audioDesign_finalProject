using UnityEngine;

public class PassiveFishing : MonoBehaviour
{
    public float fishInterval = 8f;
    private bool fishReady = false;

    void Start()
    {
        InvokeRepeating(nameof(CatchFish), fishInterval, fishInterval);
    }

    void CatchFish()
    {
        fishReady = true;
        Debug.Log("Fish is ready!");
        
    }

    public bool CollectFish()
    {
        if (!fishReady)
            return false;

        fishReady = false;
        Debug.Log("Fish collected!");
        return true;
    }
}
