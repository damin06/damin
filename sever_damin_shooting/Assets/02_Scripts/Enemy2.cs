using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    float speed = 2;
    public int hp = 4;
    public GameObject FX;
    Vector3 dir= Vector3.down;
    private void Start()
    {
   
    }
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
            if(collision.gameObject.CompareTag("Player")){
                 GameObject ex=Instantiate(FX);
                    ex.transform.position = transform.position;
            }
      
        UImanager sc = GameObject.Find("UImanager").GetComponent<UImanager>();
        sc.SetScore(sc.GetScore() +1);
      
    
           if(collision.gameObject.CompareTag("Bullet")){
               hp-=1;
                Destroy(collision.gameObject);
               if(hp==0){
                   Destroy(gameObject);
                       GameObject ex=Instantiate(FX);
              ex.transform.position = transform.position;
   
               }
        }
     
    }
}
