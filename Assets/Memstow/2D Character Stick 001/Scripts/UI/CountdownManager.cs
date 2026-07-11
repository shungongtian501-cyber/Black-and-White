using System.Collections;
using TMPro;
using UnityEngine;

public class CountdownManager : MonoBehaviour
{
    [SerializeField] private TMP_Text countdownText;

    void Start()
    {
        Time.timeScale = 0f;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        countdownText.gameObject.SetActive(true);

        countdownText.text = "3";
        yield return new WaitForSecondsRealtime(1);

        countdownText.text = "2";
        yield return new WaitForSecondsRealtime(1);

        countdownText.text = "1";
        yield return new WaitForSecondsRealtime(1);

        countdownText.text = "GO!";

        Time.timeScale = 1f;

        // プレイヤーを動けるようにする
        FindFirstObjectByType<memstow.PlayerMove2D>().canMove = true;

        // タイマー開始
        FindFirstObjectByType<TimerManager>().StartTimer();

        yield return new WaitForSecondsRealtime(0.5f);

        countdownText.gameObject.SetActive(false);
    }
}