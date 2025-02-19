﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private GameObject particle;
    private void Update()
    {
        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(particle, transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
