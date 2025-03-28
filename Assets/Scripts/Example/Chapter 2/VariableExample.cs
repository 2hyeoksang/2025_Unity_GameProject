using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // 변수의 초기화 -> 자료형 식별자 = 값 ;
    int a = 1 ;

    // 자료형의 종류
    // 1. 정수형 - int, long, byte 
    // 2. 실수형 - float, double
    // 3. 문자형 - char, string
    // 4. 논리형 - bool
    // 5. object

    string b = "hello";
    float f = 1.7f;
    // 실수 리터럴은 기본적으로 double로 처리 뒤에 d 붙이면 더블형, f 붙이면 실수형
    char c = 'c';
    bool t = false;

    object o1 = 1;
    object o2 = 2.6;

    byte n1 = 1;    // 8bit  0 ~ 255
    int n2 = 1;     // 32bit    
    long n3 = 1;    // 64bit


}
