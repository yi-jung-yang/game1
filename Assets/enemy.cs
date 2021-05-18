using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    public float speed=10;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent < Rigidbody>();
        player=GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        rb.AddForce(lookDirection*speed);
        if (transform.position.y < -10)
        {
          Destroy(gameObject);
        }
      
    }
}
