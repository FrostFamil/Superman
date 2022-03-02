using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        transform.Translate(Vector3.up*20*Time.deltaTime);

        if(Touchscreen.current.primaryTouch.press.isPressed){
            transform.Rotate(0f, steerValue * 10 * Time.deltaTime, 0f);
            transform.Translate(Vector3.right * (-steerValue) * Time.deltaTime);
        }
    }

    public void Steer(int value) {
        steerValue = value;
    }
}
