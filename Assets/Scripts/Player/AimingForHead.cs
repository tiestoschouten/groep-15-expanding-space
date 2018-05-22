﻿using System.Collections.Generic;
using UnityEngine;

public class AimingForHead : MonoBehaviour
{

    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);

        if (angle > 100 && angle < 235)
        {
            transform.rotation = rotation;
        }

    }
}