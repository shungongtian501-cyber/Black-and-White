using UnityEngine;

public class VerticalLift : LiftBase
{
    [SerializeField] private float range = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    protected override void Update()
    {
        transform.position = startPos +
            Vector3.up * Mathf.Sin(Time.time * moveSpeed) * range;
    }
}