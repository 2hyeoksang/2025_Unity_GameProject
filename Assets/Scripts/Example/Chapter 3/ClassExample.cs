using UnityEngine;

public class ClassExample : MonoBehaviour
{
    /*
        강아지
        이름 : , 나이 : , 색 : , 크기 : , 먹다. 걷다. 자다.

        1. 뽀삐
        - 이름 : 뽀삐, 나이 : 3살, 색 : 흰색, 크기 : 40cm, 먹다. 걷다. 자다. (특성과 행위 / 추상화)

        2. 초코
        - 이름 : 초코, 나이 : 5살, 색 : 갈색, 키 : 30cm, 먹다. 걷다. 자다.

     */

}
/*
 * - 클래스의 멤버
 *   사람의 속성 : 이름, 키, 나이   -> 필드 (변수)
 *   사람의 행위 : 먹다. 걷다. 자다. -> 메소드
 *   
 * - 메소드의 기본 구조
 *  접근_제한자, 반환_타입, 메소드_이름(매개변수){
 *  .. 실행할 코드
 *  }
 *  
 */
class Human
{
    private string name;
    private float height;
    private int age;

    public string Name  // name 에 접근하거나 수정하는 역할을 해줌
    {
        get {
            Debug.Log("이름에 접근함.");
            return name; 
        }
        set {
            Debug.Log("이름을 수정함.");
            name = value; 
        }    // set 없애면 외부에서 설정할 수 없음, 없애지 않고 private로 설정
    }   // 아래 GetName(), SetName()과 똑같은 기능


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