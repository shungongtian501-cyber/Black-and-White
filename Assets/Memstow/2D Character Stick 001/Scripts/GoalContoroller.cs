using UnityEngine;

public class GoalContoroller : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            Debug.Log("ゴール");
            Time.timeScale = 0;
            Camera.main.backgroundColor = Color.white;
        }
    }
}
