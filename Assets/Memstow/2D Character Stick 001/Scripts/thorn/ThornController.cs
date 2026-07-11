using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ThornController : MonoBehaviour
{
    private Vector3 pos;
    [SerializeField] private float moveRange = 5f;
    [SerializeField] private float moveSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            pos.x + Mathf.Sin(Time.time * moveSpeed) * moveRange, pos.y,pos.z );
    }
}
