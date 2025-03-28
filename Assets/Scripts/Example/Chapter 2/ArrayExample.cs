using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // 선언만 했을 때 기본값이 담기지 않음 & new : 메모리 공간에 새로운 공간을 만들어줘라
    // 배열의 크기가 5가 된거
    int score1 = 100;
    // int score2 = 200;
    int score3 = 300;
    int[] scores = new int[3];  // [0,0,0]
    int[] scores2 = new int[] { 100, 200, 300 };    //직접 값을 명시하면 초기화가 가능, 크기 굳이 안적어도됨
    int[] scores3 = { 100, 200, 300 };

     void Start()
    {
        Debug.Log(scores3[0]);
        Debug.Log(scores3[1]);
        Debug.Log(scores3[2]);

        scores3[2] = 400;
        Debug.Log(scores3[2]);
    }
}
