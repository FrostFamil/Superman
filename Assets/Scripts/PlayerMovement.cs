using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private int steerValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*10*Time.deltaTime);
        transform.Rotate(0f, steerValue * 5 * Time.deltaTime, 0f);
    }

    public void Steer(int value) {
        steerValue = value;
    }
}
