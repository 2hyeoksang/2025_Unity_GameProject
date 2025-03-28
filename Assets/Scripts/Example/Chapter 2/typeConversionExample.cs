using UnityEngine;

public class typeConversionExample : MonoBehaviour
{
    int a = 1;
    long b = 100000000000;

    void Start()
    {
        //b = a;  // 암시적 형변환
        //Debug.Log(b);
        a = (int)b; // 명시적 형변환, () : 형변환 연산자, 캐스팅 연산자 
        Debug.Log(a);
    }
}
