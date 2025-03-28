using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float time = 2.0f;
    void Start()
    {
        Invoke("DestroySelf", time);
    }

    void DestroySelf()
    {
        Destroy(gameObject);    // Bullet이 부착된 gameObject 를 삭제시킴
    }

}
