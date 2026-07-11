using System.Collections;
using UnityEngine;

public class ThornSpawner : MonoBehaviour
{
    [SerializeField] private GameObject thornPrefab;

    IEnumerator Start()
    {
        while (true)
        {
            Vector3 spawnPos = transform.position;
            spawnPos.y = Random.Range(-1f, 3f); // Yだけランダム
            spawnPos.z = 0f;    // ← 必ずZを0にする

            Instantiate(thornPrefab, spawnPos, Quaternion.Euler(0, 0, 90));

            yield return new WaitForSeconds(Random.Range(3f, 5f));
        }
    }
}