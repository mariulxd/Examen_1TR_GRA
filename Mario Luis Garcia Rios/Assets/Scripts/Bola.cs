﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] Text timeText;
    [SerializeField] Text numeroCol;
    public GameObject NumeroColumnas;
    private CrearColumnas columnasA;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = Mathf.Clamp(transform.position.x, -10, 10);
        float posZ = Mathf.Clamp(transform.position.z, -10, 10);
        MoverBola();

        columnasA = NumeroColumnas.GetComponent<CrearColumnas>();
        double timePass = Time.time;
        string total = timePass.ToString("f0");
        timeText.text = total;
        numeroCol.text = columnasA.nColumnas.ToString();

    }

    void MoverBola()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * desplY);
        /*if (posX >= -10 && posX <= 10 || posX <= -10 && posX > 0 || posX < 0 && posX >= 10)
        {
            float desplX = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        
       
        if (posZ >= -10 && posZ <= 10 || posZ < -10 && posZ > 0 || posZ < 0 && posZ > 10) 
        {
            float desplY = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplY);
        }*/

    }
}
