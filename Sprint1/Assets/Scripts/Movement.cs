using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bulletManager[] bms;

    public float speed = 0.0f;
    private CharacterController controller;
    bool shoot;
    // Start is called before the first frame update
    void Start()
    {
        bms = transform.GetComponentsInChildren<bulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        print(gameObject.transform.position.y);

        if(gameObject.transform.position.x <= -7 && h < 0)
        {
            h = 0;
        }
        if (gameObject.transform.position.x >= 7 && h > 0)
        {
            h = 0;
        }
        if (gameObject.transform.position.y <= -4.2 && v < 0)
        {
            v = 0;
        }
        if (gameObject.transform.position.y >= -1 && v > 0)
        {
            v = 0;
        }
        gameObject.transform.position = new Vector2 (transform.position.x + (h * speed), transform.position.y + (v * speed));

        shoot = Input.GetKeyDown(KeyCode.Space);
        if (shoot)
        {
            Destroy(GameObject.Find("Overlay"));
            shoot = false;
            foreach(bulletManager bm in bms)
            {
                bm.Shoot();
            }
        }

    }
}