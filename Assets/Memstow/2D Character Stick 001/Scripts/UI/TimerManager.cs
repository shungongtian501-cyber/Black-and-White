using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private float timeLimit = 60f;

    private float currentTime;

    public bool isRunning = false;

    void Start()
    {
        currentTime = timeLimit;
        timerText.text = currentTime.ToString("F1");
    }

    void Update()
    {
        if (!isRunning) return;

        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
            FindFirstObjectByType<GameManager>().GameOver();
            isRunning = false;
        }

        timerText.text = currentTime.ToString("F1");
    }

    public void StartTimer()
    {
        isRunning = true;
    }
}