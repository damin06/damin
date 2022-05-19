using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
float speed = 3.5f;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    
}
