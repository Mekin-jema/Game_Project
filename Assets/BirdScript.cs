using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{  
    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name="Mekin Jemal";
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity=Vector2.right*5;
    }
}
