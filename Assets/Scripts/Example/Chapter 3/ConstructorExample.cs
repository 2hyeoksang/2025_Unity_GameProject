using UnityEngine;

public class ConstructorExample : MonoBehaviour
{
    /*
     * 생성자의 기본 구조 (반환 타입이 없다)
     * 접근_제한자 클래스_이름(매개변수){
     * 
     * }
     */

     void Start()
    {
        Human Jane = new Human("jane", 160.3f, 23);   // 휴먼 객체 생성 & Human() : 생성자 메소드

        // Debug.Log(Jane.name);
        //Debug.Log(Jane.height);
        //Debug.Log(Jane.age);
        
    }

}
