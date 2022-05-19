using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
      float speed = 2;
    Vector3 dir= Vector3.down;
      
    public GameObject enemybullet = null;
    public GameObject FX;
  void Start()
    {
        StartCoroutine(Shooting());
    }
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player")||collision.gameObject.CompareTag("Bullet")){
             GameObject ex=Instantiate(FX);
              ex.transform.position = transform.position;
        }
        Destroy(gameObject);
      
        UImanager sc = GameObject.Find("UImanager").GetComponent<UImanager>();
        sc.SetScore(sc.GetScore() +1);
      
    
           if(collision.gameObject.CompareTag("Bullet")){
        Destroy(collision.gameObject);
        }
     
    }
    private IEnumerator Shooting()
    {
        while (true)
        {
            int shootDuration =Random.Range(1,3);
            yield return new WaitForSeconds(shootDuration);
            Instantiate(enemybullet, transform.position, Quaternion.identity);
            shootDuration =Random.Range(1,3);
        }
    }
}
