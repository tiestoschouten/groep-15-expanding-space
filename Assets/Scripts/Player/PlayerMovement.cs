
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _speed;
    public int playerHitPoints = 100;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector2 tPos = transform.position;
        tPos.x += (_speed * x) * Time.deltaTime;
        transform.position = tPos;


	
		}
    }
