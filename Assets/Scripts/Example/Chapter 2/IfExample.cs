using UnityEngine;

public class IfExample : MonoBehaviour
{
    private void Start()
    {
        float number = 3.5f;
        if(number > 5)
        {
            Debug.Log("���� 5���� ŭ");
        }
        else
        {
            Debug.Log("5���� ����");
        }
    }
}
