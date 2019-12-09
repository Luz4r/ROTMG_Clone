using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 rotationValue;

    // Start is called before the first frame update
    void Start()
    {
        rotationValue = new Vector3(0.0f, 0.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        transform.Translate(dirX * Time.deltaTime * speed, dirY * Time.deltaTime * speed, 0);
    }

    private void HandleRotation()
    {
        Camera.main.orthographicSize += -Input.mouseScrollDelta.y;
        if (Input.GetKey(KeyCode.Q))
        {
            transform.eulerAngles += rotationValue;
        }
        else if(Input.GetKey(KeyCode.E))
        {
            transform.eulerAngles -= rotationValue;
        }
    }
}
