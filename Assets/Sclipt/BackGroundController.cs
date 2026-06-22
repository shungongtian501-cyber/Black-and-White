using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private bool isBlack = false;

    [SerializeField] private SpriteRenderer floor;

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isBlack = !isBlack;

            if (isBlack)
            {
                Camera.main.backgroundColor = Color.black;
                floor.color = Color.white;
               
            }
            else
            {
                Camera.main.backgroundColor = Color.white;
                floor.color = Color.black;

            }
        }
    }
}