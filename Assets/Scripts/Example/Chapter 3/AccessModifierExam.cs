using UnityEngine;

public class AccessModifierExam : MonoBehaviour
{
    // ������������ ����
    // 1. public : �ܺο� ����
    // 2. internal : ���� ��������� ���� �����ϵ��� (������� �� ������Ʈ, public�̶� ���� ����)
    // 3. protected : �Ļ�Ŭ���������� ���� ���� 
    // 4. private : �ܺο� �������� ����

    // ���������� �����ϸ� private�� ��, �ٵ� Ŭ������ internal�� ������ 
     void Start()
    {
        Human john = new Human();
        //john.age = 1;
        john.Eat();
    }
}
