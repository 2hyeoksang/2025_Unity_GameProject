using UnityEngine;

public class ConstructorExample : MonoBehaviour
{
    /*
     * �������� �⺻ ���� (��ȯ Ÿ���� ����)
     * ����_������ Ŭ����_�̸�(�Ű�����){
     * 
     * }
     */

     void Start()
    {
        Human Jane = new Human("jane", 160.3f, 23);   // �޸� ��ü ���� & Human() : ������ �޼ҵ�

        // Debug.Log(Jane.name);
        //Debug.Log(Jane.height);
        //Debug.Log(Jane.age);
        
    }

}
