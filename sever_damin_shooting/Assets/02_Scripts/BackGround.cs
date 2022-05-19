
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackGround : MonoBehaviour
{
    Vector2 vec = Vector2.up;
    
   public Material bgmat;
   public float scrollspeed=0.2f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
      
        bgmat.mainTextureOffset+= scrollspeed * vec * Time.deltaTime;;
    }
}
