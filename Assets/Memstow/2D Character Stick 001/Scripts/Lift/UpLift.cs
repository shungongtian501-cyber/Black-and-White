using UnityEngine;

public class UpLift : LiftBase
{
    [SerializeField] private float destroyY = 30f;

    protected override void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (transform.position.y > destroyY)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > destroyY)
        {
            foreach (Transform child in transform)
            {
                child.SetParent(null);
            }

            Destroy(gameObject);
        }
    }
}