using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public Transform firePos;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet=Instantiate(bulletFactory);
            bullet.transform.position = firePos.position;
        }
    }
}
