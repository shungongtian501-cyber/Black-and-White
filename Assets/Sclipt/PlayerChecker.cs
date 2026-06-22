using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var renderers = GetComponentsInChildren<SpriteRenderer>(true);

        Debug.Log("Renderer数 : " + renderers.Length);

        foreach (var r in renderers)
        {
            r.color = Color.red;
            Debug.Log(r.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
