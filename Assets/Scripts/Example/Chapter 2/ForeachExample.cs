using UnityEngine;

public class ForeachExample : MonoBehaviour
{
    int[] numbers = {1,2,3,4,5};

    /*
        foreach(변수의 타입 변수식별자 in 배열의식별자){
            반복할 내용
        }
     */
    void Start()
    {
        for (int i = 0; i<5; i++)
        {
            Debug.Log(numbers[i]);
        }
    
        foreach(int i in numbers)
        {
            Debug.Log(i);
        }
            

    }

}
