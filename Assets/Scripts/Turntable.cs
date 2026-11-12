using UnityEngine;

public class Turntable : MonoBehaviour
{
    public float degreesPerSecond = 30f;
    public float smooth = 2f;
    public bool isRunning = true;

    private float currentSpeed = 0f;

    void Update()
    {
        float targetSpeed = 0f;

        if (isRunning == true)
        {
            targetSpeed = degreesPerSecond;
        }

        currentSpeed = Mathf.Lerp(currentSpeed, targetSpeed, smooth * Time.deltaTime);
        transform.Rotate(0f, currentSpeed * Time.deltaTime, 0f);
    }
}
