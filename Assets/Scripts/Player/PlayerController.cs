using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //gameObject -> 해당 스크립트가 부착된 게임 오브젝트
    // . -> ~의
    /*
        Vector
        -> 크기와 방향을 갖는 물리값, 좌표값 (x,y,z)

        Vector2 : (x,y) 2차원 2D
        Vector3 : (x,y,z) 3D
     */

    // 2. 플레이어 이동
    // Input.GetKey() : 키보드의 입력을 받는 메소드
    void Start()
    {
        
    }

    public float speed = 0.02f;
    public GameObject BulletPrefab;
    public float bulletspeed = 100f;
    public GameObject Gun;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))    // A가 눌릴 때마다 True 반환
        {
            transform.Translate(-speed, 0, 0);  // x축 방향으로 -1 이동, Vector2는 들어가지만 (-1,0)은 안들어감
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

        if (Input.GetKeyDown(KeyCode.Space))    // 누르고 있을 떄가 아니라, 딱 눌리는 순간만 (최초 1회) 캐치하려면 GetKeyDown
        {

            for (int i = 0; i < 3; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab);  // 해당 프리팹을 생성, instantiate라는 메소드를 통해서 
                                                                // 생성된 게임 오브젝트를 bullet 이라는 그릇에 담겠다
                //bullet.transform.position = transform.position; // Player의 포지션을 Bullet의 포지션에 대입해라
                //Vector2 pos = bullet.transform.position;
                //pos.y += i * 0.5f;
                //bullet.transform.position = pos;

                // 총알이 발사되는 부분을 조금 앞으로 수정할거임
                // Vector3 BulletStartPosition = transform.position + new Vector3(0, 0.5f,0);  // 새로운 벡터 변수를 선언할 때는 new
                
                Vector3 BulletStartPosition = Gun.transform.position;
                BulletStartPosition.y += i * 0.4f;
                bullet.transform.position = BulletStartPosition;

                bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletspeed); // 앞으로 나아가는 힘을 담당하는 컴포넌트 Rigidbody에 접근. <> generic
                                                                                       // (0, 1) * 100
            }

        }

    }

}
