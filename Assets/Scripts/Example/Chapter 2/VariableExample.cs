using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // ������ �ʱ�ȭ -> �ڷ��� �ĺ��� = �� ;
    int a = 1 ;

    // �ڷ����� ����
    // 1. ������ - int, long, byte 
    // 2. �Ǽ��� - float, double
    // 3. ������ - char, string
    // 4. ���� - bool
    // 5. object

    string b = "hello";
    float f = 1.7f;
    // �Ǽ� ���ͷ��� �⺻������ double�� ó�� �ڿ� d ���̸� ������, f ���̸� �Ǽ���
    char c = 'c';
    bool t = false;

    object o1 = 1;
    object o2 = 2.6;

    byte n1 = 1;    // 8bit  0 ~ 255
    int n2 = 1;     // 32bit    
    long n3 = 1;    // 64bit


}
