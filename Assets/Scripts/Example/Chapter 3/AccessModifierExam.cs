using UnityEngine;

public class AccessModifierExam : MonoBehaviour
{
    // 접근제한자의 종류
    // 1. public : 외부에 공개
    // 2. internal : 같은 어셈블리에서 접근 가능하도록 (어셈블리란 한 프로젝트, public이랑 거의 유사)
    // 3. protected : 파생클래스에서만 접근 가능 
    // 4. private : 외부에 공개하지 않음

    // 접근제한자 생략하면 private로 됨, 근데 클래스는 internal로 설정됨 
     void Start()
    {
        Human john = new Human();
        //john.age = 1;
        john.Eat();
    }
}
