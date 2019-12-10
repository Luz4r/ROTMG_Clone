using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public GameObject bulletPrefab;
    private List<GameObject> bullets;
    private bool isShooting = false;
    private float time;
    private float shootingFrequency;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        time = Time.time;
        shootingFrequency = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        isShooting = Input.GetMouseButton(0);
        Shoot();
    }

    private void Shoot()
    {
        if (Time.time - time > shootingFrequency && isShooting)
        {
            time = Time.time;
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 playerPos = transform.position;
            Vector2 dir = new Vector2(pos.x - playerPos.x, pos.y - playerPos.y).normalized;

            GameObject bullet = Instantiate<GameObject>(bulletPrefab, playerPos, Quaternion.FromToRotation(Vector2.up, dir));

            bullet.GetComponent<BulletMovement>().setDir(new Vector3(dir.x, dir.y) * 0.1f);
            Destroy(bullet, 1.0f); //TODO destroy bullet on some range
            bullets.Add(bullet);
        }
    }
}
