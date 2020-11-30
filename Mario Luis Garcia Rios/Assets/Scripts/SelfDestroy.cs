using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    private CrearColumnas crearColumnas;
    public GameObject ObjetoVacio;
    
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
           
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        ObjetoVacio = GameObject.Find("CrearColumnas");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
