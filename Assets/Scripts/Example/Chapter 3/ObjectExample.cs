using UnityEngine;

public class ObjectExample : MonoBehaviour
{
    // �ν��Ͻ�ȭ : Ŭ������ �̿��� ��ü�� ����
    // new Ŭ����_�̸�();    ->  ��ü ����
    void Start()
    {
        Human John = new Human();    // ��ü�� �����ߴٴ� ���� �� ��ü�� ����Ǳ� ���� �޸� ������ �Ҵ��ߴٴ� ��
        // John.name = "John";
        //John.age = 24;
        //John.height = 175;

        John.Eat();

    }

}
