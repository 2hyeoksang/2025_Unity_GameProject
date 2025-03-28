using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    private void Start()
    {
        Adult tom = new Adult("tom", 160, 24);
        // Adult tom = new Adult("tom", 160, 24);
        // 얘는 오류가 남 (3개의 argument 인수를 갖는 생성자가 없다), 생성자는 다른 방식으로 상속을 받음
        // 따로 생성자를 사용해주려면 Adult 클래스에 명시를 해줘야함
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
//    public string Name  // name 에 접근하거나 수정하는 역할을 해줌
//    {
//        get
//        {
//            Debug.Log("이름에 접근함.");
//            return name;
//        }
//        set
//        {
//            Debug.Log("이름을 수정함.");
//            name = value;
//        }    // set 없애면 외부에서 설정할 수 없음, 없애지 않고 private로 설정
//    }   // 아래 GetName(), SetName()과 똑같은 기능


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
//}   // 이렇게 할 필요 없다.

class Adult : Human
{
    public int Age;
    public Adult() { }
    public Adult(string _name, float _height, int _age) : base(_name, _height, _age) { }    // 생성자의 상속

    public void PrintName()
    {
        Debug.Log(Name);    // name은 사용할 수 없음. Human class 안에서는 private이기 때문에 외부에 공개하지 않음.
        // 자식에게 사용하게 하려면 protected 사용
    }

    public int GetBaseAge()
    {
        return base.Age;    // 만약 그냥 Age로 적으면 앞에 this가 생략되어있구나 생각하고 0이 나옴
    }
}


class Baby : Human
{

}