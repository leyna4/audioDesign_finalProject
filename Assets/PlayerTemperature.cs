using UnityEngine;

public class PlayerTemperature : MonoBehaviour
{
    public float maxTemp = 100f;
    public float currentTemp;
    public float coldRate = 5f;
    public float warmRate = 15f;

    public bool isWarming = false;

    void Start()
    {
        currentTemp = maxTemp;
    }

    void Update()
    {
        if (isWarming)
            currentTemp += warmRate * Time.deltaTime;
        else
            currentTemp -= coldRate * Time.deltaTime;

        currentTemp = Mathf.Clamp(currentTemp, 0, maxTemp);
    }
}
