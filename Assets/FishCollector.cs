using UnityEngine;

public class FishCollector : MonoBehaviour
{
    public PassiveFishing fishingRod;
    public ScoreManager scoreManager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("FishingRod"))
            {
                if (fishingRod.CollectFish())
                {
                    scoreManager.AddFish();
                }
            }
        }
    }
}
