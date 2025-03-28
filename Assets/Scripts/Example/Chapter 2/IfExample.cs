using UnityEngine;

public class IfExample : MonoBehaviour
{
    private void Start()
    {
        float number = 3.5f;
        if(number > 5)
        {
            Debug.Log("값이 5보다 큼");
        }
        else
        {
            Debug.Log("5보다 작음");
        }
    }
}
