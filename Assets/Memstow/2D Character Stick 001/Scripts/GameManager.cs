using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer thorn;
    [SerializeField] private SpriteRenderer ground;
    [SerializeField] private GameObject clearText;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject retryButton;
    [SerializeField] private GameObject stageserectButton;
    [SerializeField] private GameObject nextstagebutton;


    private bool isGameOver = false;

    void Start()
    {
        gameOverText.SetActive(false);
        clearText.SetActive(false);
        retryButton.SetActive(false);
        stageserectButton.SetActive(false);
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        // 背景
        Camera.main.backgroundColor = Color.white;

        // トゲを全部黒に
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("thorn"))
        {
            obj.GetComponent<SpriteRenderer>().color = Color.black;
        }
        //床を黒に
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Ground"))
        {
            obj.GetComponent<SpriteRenderer>().color = Color.black;
        }
        gameOverText.SetActive(true);
        retryButton.SetActive(true);
        stageserectButton.SetActive(true);


        Time.timeScale = 0f;
    }
    public void GameClear()
    {
        if (isGameOver) return;

        isGameOver = true;

        clearText.SetActive(true);
        retryButton.SetActive(true);
        nextstagebutton.SetActive(true);

        Time.timeScale = 0f;
    }
    public void Retry()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("リトライ");
    }
    public void serectstage()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("StageScene");
    }
    public void NextStage()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current + 1);
    }
}