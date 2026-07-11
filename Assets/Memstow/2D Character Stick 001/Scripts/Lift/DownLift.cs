using UnityEngine;

public class DownLift : LiftBase
{
    [SerializeField] private float destroyY = -6f;

    protected override void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        if (transform.position.y < destroyY)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < destroyY)
        {
            foreach (Transform child in transform)
            {
                child.SetParent(null);
            }

            Destroy(gameObject);
        }
    }
}