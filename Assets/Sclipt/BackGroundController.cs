using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private bool isBlack = false;

    [SerializeField] private SpriteRenderer floor;
    [SerializeField] private SpriteRenderer blocks;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isBlack = !isBlack;

            if (isBlack)
            {
                Camera.main.backgroundColor = Color.black;
                floor.color = Color.white;
                blocks.color = Color.white;
               
            }
            else
            {
                Camera.main.backgroundColor = Color.white;
                floor.color = Color.black;
                blocks.color = Color.black;
            }
        }
    }
}