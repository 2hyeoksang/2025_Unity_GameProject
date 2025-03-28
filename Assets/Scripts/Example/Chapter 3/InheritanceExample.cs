using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    private void Start()
    {
        Adult tom = new Adult("tom", 160, 24);
        // Adult tom = new Adult("tom", 160, 24);
        // ��� ������ �� (3���� argument �μ��� ���� �����ڰ� ����), �����ڴ� �ٸ� ������� ����� ����
        // ���� �����ڸ� ������ַ��� Adult Ŭ������ ��ø� �������
        tom.PrintName();
        Debug.Log(tom.GetBaseAge());

    }
}

//class Adult
//{
//    private string name;
//    private float height;
//    private int age;

//    public Adult() { }

//    public Adult(string _name, float _height, int _age)
//    {
//        name = _name;
//        height = _height;
//        age = _age; 
//    }
//    public string Name  // name �� �����ϰų� �����ϴ� ������ ����
//    {
//        get
//        {
//            Debug.Log("�̸��� ������.");
//            return name;
//        }
//        set
//        {
//            Debug.Log("�̸��� ������.");
//            name = value;
//        }    // set ���ָ� �ܺο��� ������ �� ����, ������ �ʰ� private�� ����
//    }   // �Ʒ� GetName(), SetName()�� �Ȱ��� ���


//    public float Height
//    {
//        get { return height; }
//        set { height = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }

//    public void Eat()
//    {
//        Debug.Log("eat!");
//    }

//    public void Walk()
//    {
//        Debug.Log("Walk!");
//    }

//    public void Sleep()
//    {
//        Debug.Log("sleep!");
//    }
//}   // �̷��� �� �ʿ� ����.

class Adult : Human
{
    public int Age;
    public Adult() { }
    public Adult(string _name, float _height, int _age) : base(_name, _height, _age) { }    // �������� ���

    public void PrintName()
    {
        Debug.Log(Name);    // name�� ����� �� ����. Human class �ȿ����� private�̱� ������ �ܺο� �������� ����.
        // �ڽĿ��� ����ϰ� �Ϸ��� protected ���
    }

    public int GetBaseAge()
    {
        return base.Age;    // ���� �׳� Age�� ������ �տ� this�� �����Ǿ��ֱ��� �����ϰ� 0�� ����
    }
}


class Baby : Human
{

}