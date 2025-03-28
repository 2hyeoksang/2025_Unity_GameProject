using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    private void Start()
    {
        int number = 5;
        switch (number)
        {
            case 1:
                Debug.Log("값이 1입니다");
             break;

            case 2:
                Debug.Log("값이 2입니다");
                break;

            case 3:
                Debug.Log("값이 3입니다");
                break;

            default:
                Debug.Log("ㅋㅋ");
                break;

        }
    }
}
