using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour {



    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);// - transform.position;
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        //Quaternion rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
        angle = Mathf.Clamp(angle, -90, 90);

        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, angle);

        /*
        if (angle > 0 && angle < 170)
        {
            transform.rotation = rotation;

            if (angle > 170)
            {
                transform.Rotate ( 0, 0, -1);
            }
        }
        if (angle > 170 && angle < 340)
        {
            transform.rotation = rotation;

            if (angle < 170)
            {
                transform.Rotate(0, 0, -1);
            }
        }

        */
    }
}