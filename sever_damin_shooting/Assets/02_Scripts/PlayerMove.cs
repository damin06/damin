using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{
        public Slider hpSlider;
     public float Damage = 0.2f;
    public float speed=5;  
    void Update()
    {
           
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        //->.d : 1. <-,a : -1, 0 
        float h = Input.GetAxis("Horizontal");
        //-1,0,1
        float v = Input.GetAxis("Vertical");
       // Debug.Log("h: " + h + " v: " +v);
        Vector3 dir = new Vector3(h, v, 0);
        dir = (dir.magnitude > 1) ? dir.normalized : dir;
        transform.Translate(dir * speed * Time.deltaTime);
    }
     private void OnCollisionEnter(Collision collision)
     {
        if(collision.gameObject.CompareTag("Enemy")){
       hpSlider.value -= Damage;
       if(hpSlider.value==0){
              SceneManager.LoadScene("GameOver");
       }
    
        }
        if(collision.gameObject.CompareTag("enemybullet")){
               hpSlider.value -= Damage;
               Destroy(collision.gameObject);
       if(hpSlider.value==0){
              SceneManager.LoadScene("GameOver");
        }
        }
        
        if(collision.gameObject.CompareTag("enemyamor")){
       hpSlider.value -= Damage;
       Destroy(collision.gameObject);
       if(hpSlider.value==0){
              SceneManager.LoadScene("GameOver");
       }
     }
//   public void hp(){
//       hpSlider.value -= Damage;
//   }

      }
 }
