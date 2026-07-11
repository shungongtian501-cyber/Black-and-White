using System.Collections;
using UnityEngine;

public class DownLiftSpawner : MonoBehaviour
{
    [SerializeField] private GameObject downliftPrefab;
    [SerializeField] private float spawnInterval = 2f;

    IEnumerator Start()
    {
        Debug.Log("Startが呼ばれた");
        Debug.Log("Object : " + gameObject.name);
        Debug.Log("Prefab : " + downliftPrefab);
        while (true)
        {
            Debug.Log($"downliftPrefab = {downliftPrefab}");
            if (downliftPrefab == null)
            {
                Debug.LogError("downliftPrefab が null です");
                yield break;
            }

            Instantiate(downliftPrefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}   