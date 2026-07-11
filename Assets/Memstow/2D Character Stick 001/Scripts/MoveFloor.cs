using System.Collections;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    [SerializeField] float _movepower = -1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, _movepower * Time.deltaTime, 0);

        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
