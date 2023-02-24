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
        float v = 0;
   
        gameObject.transform.position = new Vector2 (transform.position.x + (h * speed), 
        transform.position.y + (v * speed));

        shoot = Input.GetKeyDown(KeyCode.Space);
        if (shoot)
        {
            shoot = false;
            foreach(bulletManager bm in bms)
            {
                bm.Shoot();
            }
        }

    }
}
