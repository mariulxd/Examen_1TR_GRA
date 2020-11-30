using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour
{
    public float speed = 5f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MoverBola();

      

    }

    void MoverBola()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float desplX = Input.GetAxis("Horizontal");
        float desplZ = Input.GetAxis("Vertical");
        if (posX > -10 && posX < 10 || posX < -10 && desplX > 0 || posX > 10 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        if (posZ > -10 && posZ < 10 || posZ < -10 && desplZ > 0 || posZ > 10 && desplZ < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        }


    }
        
       
        

}

