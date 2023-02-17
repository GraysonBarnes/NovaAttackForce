using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidManager : MonoBehaviour
{
    public Asteroid asteroid;
    private float spawnTime = 0.0f;
    public float period = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            spawnTime += period;
            Debug.Log("hello");
            float xLean = (Random.Range(-2.0f, 2.0f));
            Vector2 vec = new Vector2(xLean, -1.0f);
            vec = vec.normalized;
            float xPos = (Random.Range(-5.0f, 5.0f));
            spawnAsteroid(vec, xPos);
        }

    }

    public void spawnAsteroid(Vector2 direction, float xPos)
    {
        Vector3 position = transform.position;
        position.x = xPos;
        GameObject bo = Instantiate(asteroid.gameObject, position, Quaternion.identity);
        Asteroid bob = bo.GetComponent<Asteroid>();
        bob.direction = direction;
    }
}
