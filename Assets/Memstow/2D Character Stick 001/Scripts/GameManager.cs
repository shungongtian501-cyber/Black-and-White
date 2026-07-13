using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject clearText;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject retryButton;
    [SerializeField] private GameObject stageserectButton;
    [SerializeField] private GameObject nextstagebutton;
    public static bool IsPlaying = false; 


    private bool isGameOver = false;

    void Start()
    {
        IsPlaying = false;

        gameOverText.SetActive(false);
        clearText.SetActive(false);
        retryButton.SetActive(false);
        stageserectButton.SetActive(false);

        if (nextstagebutton != null)
        {
            nextstagebutton.SetActive(false);
        }
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;
        IsPlaying = false;

        BGMManager.Instance.StopBGM();

        SoundManager.Instance.PlayGameOver();

        // 背景
        Camera.main.backgroundColor = Color.white;

        ChangeColor("thorn", Color.black);
        ChangeColor("Ground", Color.black);

        gameOverText.SetActive(true);
        retryButton.SetActive(true);
        stageserectButton.SetActive(true);


        Time.timeScale = 0f;
    }
    public void GameClear()
    {
        IsPlaying = false;

        StartCoroutine(GameClearSequence());
    }
    IEnumerator GameClearSequence()
    {
        clearText.SetActive(true);

        BGMManager.Instance.StopBGM();

        SoundManager.Instance.PlayGameClear();

        yield return new WaitForSeconds(1.5f);


        // 次のステージ解放
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        int unlockedStage = PlayerPrefs.GetInt("UnlockedStage", 2);

        if (nextScene > unlockedStage)
        {
            PlayerPrefs.SetInt("UnlockedStage", nextScene);
            PlayerPrefs.Save();
        }


        // ボタン表示
        nextstagebutton.SetActive(true);
        stageserectButton.SetActive(true);

        // ゲーム停止
        Time.timeScale = 0f;
    }

    public void Retry()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
      SceneManager.GetActiveScene().buildIndex
  );
    }
    public void serectstage()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(1);
    }
    public void NextStage()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex + 1
        );
    }

    private void ChangeColor(string tag, Color color)
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag(tag))
        {
            SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();

            if (sr != null)
            {
                sr.color = color;
            }
        }
    }
}