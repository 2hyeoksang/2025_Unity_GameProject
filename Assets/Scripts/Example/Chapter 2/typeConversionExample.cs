using UnityEngine;

public class typeConversionExample : MonoBehaviour
{
    int a = 1;
    long b = 100000000000;

    void Start()
    {
        //b = a;  // �Ͻ��� ����ȯ
        //Debug.Log(b);
        a = (int)b; // ����� ����ȯ, () : ����ȯ ������, ĳ���� ������ 
        Debug.Log(a);
    }
}
