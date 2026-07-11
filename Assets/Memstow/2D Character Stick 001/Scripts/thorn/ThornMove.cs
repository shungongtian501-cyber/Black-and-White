using UnityEngine;

public class ThornMove : MonoBehaviour
{
    [SerializeField] private float speed = 8f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // 画面外へ行ったら削除
        if (transform.position.x < -30f)
        {
            Destroy(gameObject);
        }
    }
}