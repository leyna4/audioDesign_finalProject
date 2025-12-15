using UnityEngine;

public class TentWarmZone : MonoBehaviour
{
    public PlayerTemperature playerTemp;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerTemp.isWarming = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerTemp.isWarming = false;
    }
}
