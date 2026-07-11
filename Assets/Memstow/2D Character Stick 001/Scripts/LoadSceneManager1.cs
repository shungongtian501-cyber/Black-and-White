using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BackToTitle()
    {
        Time.timeScale = 1.0f;

        SceneManager.LoadScene("TitleScene");
    }
    public void LoadGame1()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("GameScene1-1");
    }

    public void LoadGame2()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("GameScene1-2");
    }
}
