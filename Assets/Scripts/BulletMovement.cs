using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        if(dir == null)
        {
            dir = Vector3.zero;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir;
    }

    public void setDir(Vector3 dir)
    {
        this.dir = dir;
    }
}
