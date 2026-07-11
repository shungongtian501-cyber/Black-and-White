using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private bool isBlack = false;

    void Update()
    {
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
            }
            else
            {
                Camera.main.backgroundColor = Color.white;

                ChangeColor("Floor", Color.black);
                ChangeColor("Block", Color.black);
                ChangeColor("thorn", Color.black);
            }
        }
    }
    private void ChangeColor(string tag, Color color)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);

        foreach (GameObject obj in objects)
        {
            SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();

            if (sr != null)
            {
                sr.color = color;
            }
        }
    }
}