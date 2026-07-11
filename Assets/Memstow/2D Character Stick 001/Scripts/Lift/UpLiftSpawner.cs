using System.Collections;
using UnityEngine;

public class UpLiftSpawner : MonoBehaviour
{
    [SerializeField] private GameObject upliftPrefab;
    [SerializeField] private float spawnInterval = 5f;

    IEnumerator Start()
    {
        while (true)
        {
            Debug.Log($"upliftPrefab = {upliftPrefab}");
            if (upliftPrefab == null)
            {
                Debug.LogError("upliftPrefab が null です");
                yield break;
            }

            Instantiate(upliftPrefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}