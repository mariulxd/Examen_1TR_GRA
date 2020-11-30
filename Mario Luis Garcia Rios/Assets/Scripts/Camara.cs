using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] GameObject Personaje;
    private Transform playerPosition;
    
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Personaje = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Personaje.GetComponent<Transform>();
        Vector3 targetPosition = new Vector3(playerPosition.position.x, transform.position.y, playerPosition.position.z - 11f);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }
}
