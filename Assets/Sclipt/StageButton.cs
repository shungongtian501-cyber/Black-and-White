using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StageButton : MonoBehaviour
{
    [SerializeField] private int stageBuildIndex;

    private Button button;


    void Awake()
    {
        button = GetComponent<Button>();
    }


    void Start()
    {
        int unlockedStage = PlayerPrefs.GetInt("UnlockedStage", 2);

        Debug.Log("解放ステージ:" + unlockedStage);

        button.interactable = stageBuildIndex <= unlockedStage;

        button.onClick.AddListener(OnClickStage);
    }


    private void OnClickStage()
    {
        SceneManager.LoadScene(stageBuildIndex);
    }
}