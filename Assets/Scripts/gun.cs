using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
	public int playerNumber = 1;
	public GameObject missilePrefab;
 
    public Transform fireTransform;

    public float fireForce = 2000f;

    private GameObject missile;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update() 
    {
      if(Input.GetButtonDown("Fire1"))
      { 

        missile = Instantiate (missilePrefab, fireTransform.position, transform.rotation) as GameObject;
        Rigidbody missileBody = missile.GetComponent<Rigidbody>();

        missileBody.AddForce(transform.forward * fireForce);     
      }   
    }

}
