using System.Collections;
using TMPro;
using UnityEngine;

public class CountdownManager : MonoBehaviour
{
    [SerializeField] private TMP_Text countdownText;

    void Start()
    {
        Time.timeScale = 0f;

        StartCoroutine(StartSequence());

        SoundManager.Instance.PlayCountdown();
    }


    public IEnumerator StartSequence()
    {

        yield return StartCoroutine(Countdown());
    }


    private IEnumerator Countdown()
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

        GameManager.IsPlaying = true;

        FindFirstObjectByType<TimerManager>().StartTimer();

        BGMManager.Instance.PlayBGM();


        yield return new WaitForSecondsRealtime(0.5f);

        countdownText.gameObject.SetActive(false);
    }
}