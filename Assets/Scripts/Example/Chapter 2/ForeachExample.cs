using UnityEngine;

public class ForeachExample : MonoBehaviour
{
    int[] numbers = {1,2,3,4,5};

    /*
        foreach(������ Ÿ�� �����ĺ��� in �迭�ǽĺ���){
            �ݺ��� ����
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
