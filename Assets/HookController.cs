using UnityEngine;

public class HookController : MonoBehaviour
{
    public GameObject icePrefab;
    public Transform attachPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(icePrefab, pos, Quaternion.identity);
        }
    }
}
