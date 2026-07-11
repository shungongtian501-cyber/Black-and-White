using TMPro;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private GameObject clearText;

    void Start()
    {
        clearText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Goal"))
        {
            clearText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}