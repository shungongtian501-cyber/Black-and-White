using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRenderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
