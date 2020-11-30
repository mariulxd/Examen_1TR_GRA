using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfDestroy : MonoBehaviour
{
    public GameObject EmptyObject;
    private CrearColumnas ClaseCreacion;
    void OnTriggerEnter(Collider other)
    {
        ClaseCreacion = EmptyObject.GetComponent<CrearColumnas>();
        
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            ClaseCreacion.nColumnas--;

        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
