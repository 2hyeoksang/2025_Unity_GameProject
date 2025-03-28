using UnityEngine;

public class ClassExample : MonoBehaviour
{
    /*
        ������
        �̸� : , ���� : , �� : , ũ�� : , �Դ�. �ȴ�. �ڴ�.

        1. �ǻ�
        - �̸� : �ǻ�, ���� : 3��, �� : ���, ũ�� : 40cm, �Դ�. �ȴ�. �ڴ�. (Ư���� ���� / �߻�ȭ)

        2. ����
        - �̸� : ����, ���� : 5��, �� : ����, Ű : 30cm, �Դ�. �ȴ�. �ڴ�.

     */

}
/*
 * - Ŭ������ ���
 *   ����� �Ӽ� : �̸�, Ű, ����   -> �ʵ� (����)
 *   ����� ���� : �Դ�. �ȴ�. �ڴ�. -> �޼ҵ�
 *   
 * - �޼ҵ��� �⺻ ����
 *  ����_������, ��ȯ_Ÿ��, �޼ҵ�_�̸�(�Ű�����){
 *  .. ������ �ڵ�
 *  }
 *  
 */
class Human
{
    private string name;
    private float height;
    private int age;

    public string Name  // name �� �����ϰų� �����ϴ� ������ ����
    {
        get {
            Debug.Log("�̸��� ������.");
            return name; 
        }
        set {
            Debug.Log("�̸��� ������.");
            name = value; 
        }    // set ���ָ� �ܺο��� ������ �� ����, ������ �ʰ� private�� ����
    }   // �Ʒ� GetName(), SetName()�� �Ȱ��� ���


    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public Human()
    {

    }
    public Human(string name, float _height, int _age)  
    {
        this.name = name;
        height = _height;
        age = _age;
    }

    public void Eat()
    {
        Debug.Log("eat!");
    }

    public void Walk()
    {
        Debug.Log("Walk!");
    }

    public void Sleep()
    {
        Debug.Log("sleep!");
    }
}