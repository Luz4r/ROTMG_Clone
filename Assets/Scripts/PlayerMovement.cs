using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector3 rotationValue = new Vector3(0.0f, 0.0f, 1.0f);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        transform.Translate(dirX * Time.fixedDeltaTime * speed, dirY * Time.fixedDeltaTime * speed, 0.0f);
    }

    private void HandleRotation()
    {
        Camera.main.orthographicSize += -Input.mouseScrollDelta.y;
        if (Input.GetKey(KeyCode.Q))
        {
            transform.eulerAngles += rotationValue;
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.eulerAngles -= rotationValue;
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            transform.eulerAngles = Vector3.zero;
        }
    }
}
