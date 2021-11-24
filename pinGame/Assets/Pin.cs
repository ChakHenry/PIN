using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pin : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D Rb;
    

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Rotator")
        {
            Rb.velocity = Vector2.zero;
            coll.GetComponent<Rotator>().RSpeed += 10;
            transform.SetParent(coll.transform);
            GameObject.FindObjectOfType<PinSpawn>().SpawnPin();
            Score.SC++;
            
        }
        else if (coll.tag == "Pin")
        {
            GameObject.FindObjectOfType<GM>().GameOver();
        }
    }

    public void shoot()
    {
        //發射針
        Rb.velocity = Vector2.up * speed; 
    }


}
