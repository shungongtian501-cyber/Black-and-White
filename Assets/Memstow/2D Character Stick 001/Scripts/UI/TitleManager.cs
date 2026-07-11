using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void SerectGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("StageScene");
    }
    public void QuitGame()
    {
        Debug.Log("ゲーム終了");

        Application.Quit();
    }
}