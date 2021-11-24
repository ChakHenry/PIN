using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RSpeed = 90f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, RSpeed*Time.deltaTime);
    }
}
