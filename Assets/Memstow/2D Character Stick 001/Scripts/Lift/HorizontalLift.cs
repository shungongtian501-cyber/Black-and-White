using UnityEngine;

public class HorizontalLift : LiftBase
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
            Vector3.right * Mathf.Sin(Time.time * moveSpeed) * range;
    }
}