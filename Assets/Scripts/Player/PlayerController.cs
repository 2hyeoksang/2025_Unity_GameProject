using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //gameObject -> �ش� ��ũ��Ʈ�� ������ ���� ������Ʈ
    // . -> ~��
    /*
        Vector
        -> ũ��� ������ ���� ������, ��ǥ�� (x,y,z)

        Vector2 : (x,y) 2���� 2D
        Vector3 : (x,y,z) 3D
     */

    // 2. �÷��̾� �̵�
    // Input.GetKey() : Ű������ �Է��� �޴� �޼ҵ�
    void Start()
    {
        
    }

    public float speed = 0.02f;
    public GameObject BulletPrefab;
    public float bulletspeed = 100f;
    public GameObject Gun;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))    // A�� ���� ������ True ��ȯ
        {
            transform.Translate(-speed, 0, 0);  // x�� �������� -1 �̵�, Vector2�� ������ (-1,0)�� �ȵ�
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))    // ������ ���� ���� �ƴ϶�, �� ������ ������ (���� 1ȸ) ĳġ�Ϸ��� GetKeyDown
        {

            for (int i = 0; i < 3; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab);  // �ش� �������� ����, instantiate��� �޼ҵ带 ���ؼ� 
                                                                // ������ ���� ������Ʈ�� bullet �̶�� �׸��� ��ڴ�
                //bullet.transform.position = transform.position; // Player�� �������� Bullet�� �����ǿ� �����ض�
                //Vector2 pos = bullet.transform.position;
                //pos.y += i * 0.5f;
                //bullet.transform.position = pos;

                // �Ѿ��� �߻�Ǵ� �κ��� ���� ������ �����Ұ���
                // Vector3 BulletStartPosition = transform.position + new Vector3(0, 0.5f,0);  // ���ο� ���� ������ ������ ���� new
                
                Vector3 BulletStartPosition = Gun.transform.position;
                BulletStartPosition.y += i * 0.4f;
                bullet.transform.position = BulletStartPosition;

                bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletspeed); // ������ ���ư��� ���� ����ϴ� ������Ʈ Rigidbody�� ����. <> generic
                                                                                       // (0, 1) * 100
            }

        }

    }

}
