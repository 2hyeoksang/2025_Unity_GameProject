using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // ���� ���� �� �⺻���� ����� ���� & new : �޸� ������ ���ο� ������ ��������
    // �迭�� ũ�Ⱑ 5�� �Ȱ�
    int score1 = 100;
    // int score2 = 200;
    int score3 = 300;
    int[] scores = new int[3];  // [0,0,0]
    int[] scores2 = new int[] { 100, 200, 300 };    //���� ���� ����ϸ� �ʱ�ȭ�� ����, ũ�� ���� �������
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
