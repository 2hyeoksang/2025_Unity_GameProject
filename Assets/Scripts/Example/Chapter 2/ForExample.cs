using UnityEngine;

public class ForExample : MonoBehaviour
{
    /*
        for(초기화; 조건식; 반복자){
            반복할 코드
        }
     */
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        for (int i = 0; i<11; i += 2)
        {
            Debug.Log (i);
        }
    }
}
