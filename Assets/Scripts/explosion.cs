﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{

    public GameObject explosionObj;

     private void OnCollisionEnter (Collision collision)
    {
       
        //  Destroy(collision.gameObject);

        if (collision.gameObject.tag.Equals("brickWall"))
        {
            Instantiate(explosionObj, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
       

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
