using UnityEngine;
using UnityEngine.UIElements;

public class BackGroundController : MonoBehaviour
{
    private bool isBlack = false;
    [SerializeField] private SpriteRenderer floor;
    [SerializeField] private SpriteRenderer block;
    [SerializeField] private SpriteRenderer thorn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            isBlack = !isBlack;
            if (isBlack)
            {
                Camera.main.backgroundColor = Color.black;
                floor.color = Color.white;
                //block.color = Color.white;
                //thorn.color = Color.white;
            }
            else
            {
                Camera.main.backgroundColor= Color.white;
                floor.color = Color.black;
               // block.color = Color.black;
               // thorn.color = Color.black;
            }
            
        }
    }
}
