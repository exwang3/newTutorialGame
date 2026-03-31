using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(0.5f, 2.0f);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
