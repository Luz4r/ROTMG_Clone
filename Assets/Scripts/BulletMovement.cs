using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Vector3 velocity;

    public Vector3 Velocity { get => velocity; }

    // Start is called before the first frame update
    void Start()
    {
        if(velocity == null)
        {
            velocity = Vector3.zero;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += velocity;
    }

    public void setVelocity(Vector2 dir, float speed)
    {
        velocity = dir * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Colliding with enemy");
            Destroy(gameObject);
        }
    }
}
