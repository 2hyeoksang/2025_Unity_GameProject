using UnityEngine;

public class MethodExample : MonoBehaviour
{
    // 1. Half -> �Է� ���� ������ ������ ��ȯ���ִ� �޼ҵ�
    // 2. ��ȯ���� ���� �޼ҵ� : PrintNumber
    // 3. �Ű������� ���� �޼ҵ� : GetTen
    // 4. �Ű������� ���� ���� �޼ҵ� : Add
    // 5. ��ȯ���� ���� �Ű������� ���� �޼ҵ� : PrintHello
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
