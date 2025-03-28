using UnityEngine;

public class MethodExample : MonoBehaviour
{
    // 1. Half -> 입력 값을 반으로 나누어 반환해주는 메소드
    // 2. 반환값이 없는 메소드 : PrintNumber
    // 3. 매개변수가 없는 메소드 : GetTen
    // 4. 매개변수가 여러 개인 메소드 : Add
    // 5. 반환값도 없고 매개변수도 없는 메소드 : PrintHello
    float Half(float num)
    {
        return num / 2;
    }

    void PrintNumber(int num)
    {
        Debug.Log(num);
    }

    int GetTen()
    {
        return 10;
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    void PrintHello()
    {
        Debug.Log("Hello");
    }
    private void Start()
    {
        //float result = Half(10);
        //Debug.Log(result);

        //PrintNumber(10);

        //Debug.Log(GetTen());
        //Debug.Log(Add(1, 3));
        PrintHello();

    }
}
