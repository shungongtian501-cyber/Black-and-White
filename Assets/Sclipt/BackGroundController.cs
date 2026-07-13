using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundController : MonoBehaviour
{
    private bool isBlack = false;

    void Update()
    {

        if (!GameManager.IsPlaying) return;

        if (Input.GetKeyDown(KeyCode.R))
        {

            isBlack = !isBlack;

            GameObject[] floors = GameObject.FindGameObjectsWithTag("Floor");

            if (isBlack)
            {
                Camera.main.backgroundColor = Color.black;

                ChangeColor("Floor", Color.white);
                ChangeColor("Block", Color.white);
                ChangeColor("thorn", Color.white);
                ChangeColor("Text", Color.white);
                ChangeColor("TimeText", Color.white);
            }
            else
            {
                Camera.main.backgroundColor = Color.white;

                ChangeColor("Floor", Color.black);
                ChangeColor("Block", Color.black);
                ChangeColor("thorn", Color.black);
                ChangeColor("Text", Color.black);
                ChangeColor("TimeText", Color.black);
            }
        }
    }
    private void ChangeColor(string tag, Color color)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);

        foreach (GameObject obj in objects)
        {
            // SpriteRenderer
            SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.color = color;
            }

            // Legacy UI Text
            Text text = obj.GetComponent<Text>();
            if (text != null)
            {
                text.color = color;
            }

            // TextMeshPro
TMP_Text timerText = obj.GetComponent<TMP_Text>();
if (timerText != null)
{
    timerText.color = color;
}
        }
    }
}