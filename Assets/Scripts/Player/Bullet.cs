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
        Destroy(gameObject);    // Bullet�� ������ gameObject �� ������Ŵ
    }

}
