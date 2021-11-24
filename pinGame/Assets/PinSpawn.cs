using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawn : MonoBehaviour
{
    public GameObject Pin;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           // SpawnPin();
            GameObject.FindObjectOfType<Pin>().shoot();
        }
    }

   public void SpawnPin()
    {
        //生成針
        Instantiate(Pin, transform.position, transform.rotation);
    }
}
