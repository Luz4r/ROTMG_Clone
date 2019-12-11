using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingFrequency = 0.3f;
    public float range = 1;
    public float bulletSpeed = 0.4f;


    private bool isShooting = false;
    private float time;
    private SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
        sceneController = GameObject.FindGameObjectWithTag("SceneController").GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        //isShooting = Input.GetMouseButton(0);
        if(Input.GetKeyDown(KeyCode.C))
        {
            isShooting = !isShooting;
        }
        Shoot();
    }

    private void Shoot()
    {
        if (isShooting && Time.time - time > shootingFrequency)
        {
            time = Time.time;
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 playerPos = transform.position;
            Vector2 dir = new Vector2(pos.x - playerPos.x, pos.y - playerPos.y).normalized;
            Vector2 bulletPos = playerPos + dir;

            GameObject bullet = Instantiate<GameObject>(bulletPrefab, bulletPos, Quaternion.FromToRotation(Vector2.up, dir));
            bullet.GetComponent<BulletMovement>().setVelocity(dir, bulletSpeed);

            sceneController.AddBullet(bullet, range);
        }
    }
}
