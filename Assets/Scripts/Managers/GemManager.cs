using Controllers.Player;
using UnityEngine;

public class GemManager : MonoBehaviour
{
    public PlayerMovementController playerMovementController;
    public float necessaryTime = 2f;
    float timepassed20;
    float timepassed50;
    float timepassed100;

    public bool gem20;
    public bool gem50;
    public bool gem100;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "20")
        {
            timepassed20 += Time.fixedDeltaTime;
            if (timepassed20 > necessaryTime)
            {
                gem20 = true;              
            }
        }
        if (other.tag == "50")
        {
            timepassed50 += Time.fixedDeltaTime;
            if (timepassed50 > necessaryTime)
            {
                gem50 = true;
            }
        }
        if (other.tag == "100")
        {
            timepassed100 += Time.fixedDeltaTime;
            if (timepassed100 > necessaryTime)
            {
                gem100 = true;
            }
        }
    }
}
