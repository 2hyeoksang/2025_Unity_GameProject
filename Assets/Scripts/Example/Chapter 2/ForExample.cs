using UnityEngine;

public class ForExample : MonoBehaviour
{
    /*
        for(�ʱ�ȭ; ���ǽ�; �ݺ���){
            �ݺ��� �ڵ�
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
