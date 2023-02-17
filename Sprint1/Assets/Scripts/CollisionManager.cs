using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject[] shots = GameObject.FindGameObjectsWithTag("Bullet");

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        GameObject player = GameObject.FindGameObjectWithTag("Player");


        for (int i = 0; i < shots.Length; i++)
        {

            for (int j = 0; j < enemies.Length; j++)
            {

                if (AABBCollision(shots[i], enemies[j]))
                {

                    Destroy(shots[i]);

                    Destroy(enemies[j]);
                }

            }


        }



        for (int j = 0; j < enemies.Length; j++)
        {

            if (AABBCollision(player, enemies[j]))
            {

                Destroy(player);

                Destroy(enemies[j]);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }






    }

    public bool AABBCollision(GameObject A, GameObject B)
    {

        Vector3 aMin = A.GetComponent<SpriteRenderer>().bounds.min;
        Vector3 aMax = A.GetComponent<SpriteRenderer>().bounds.max;

        Vector3 bMin = B.GetComponent<SpriteRenderer>().bounds.min;
        Vector3 bMax = B.GetComponent<SpriteRenderer>().bounds.max;

        if (bMin.x < aMax.x && bMax.x > aMin.x && bMin.y < aMax.y && bMax.y > aMin.y)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


}
