using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) //Destroys objects that will go out of player's view from the top.
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) //same with the if statement but for the bottom.
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
