using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public GameObject bulletPrefab;
    private List<GameObject> bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject bullet = Instantiate<GameObject>(bulletPrefab, pos, Quaternion.identity);
            bullets.Add(bullet);
        }
    }
}
