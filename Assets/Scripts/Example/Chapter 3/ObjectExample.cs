using UnityEngine;

public class ObjectExample : MonoBehaviour
{
    // 인스턴스화 : 클래스를 이용해 객체를 생성
    // new 클래스_이름();    ->  객체 생성
    void Start()
    {
        Human John = new Human();    // 객체를 생성했다는 것은 이 객체가 저장되기 위한 메모리 공간을 할당했다는 것
        // John.name = "John";
        //John.age = 24;
        //John.height = 175;

        John.Eat();

    }

}
