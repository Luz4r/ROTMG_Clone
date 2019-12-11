using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    private List<GameObject> bullets;

    private void Awake()
    {
        bullets = new List<GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddBullet(GameObject bullet, float range)
    {
        //bullets.Add(bullet);
        float timeToDestroy = range / bullet.GetComponent<BulletMovement>().Velocity.magnitude;
        Destroy(bullet, timeToDestroy);
    }
}
