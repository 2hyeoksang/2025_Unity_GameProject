using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    private void Start()
    {
        int number = 5;
        switch (number)
        {
            case 1:
                Debug.Log("���� 1�Դϴ�");
             break;

            case 2:
                Debug.Log("���� 2�Դϴ�");
                break;

            case 3:
                Debug.Log("���� 3�Դϴ�");
                break;

            default:
                Debug.Log("����");
                break;

        }
    }
}
