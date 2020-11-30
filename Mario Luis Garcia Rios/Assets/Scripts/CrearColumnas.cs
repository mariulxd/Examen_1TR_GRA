using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    public GameObject MyColumn;
    [SerializeField] Transform RefPos;
    Vector3 NewPos;
    public int nColumnas = 0;

    // Start is called before the first frame update
    void Start()
    {
        nColumnas = 0;
        StartCoroutine("ColumnCorrutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearColumna()
    {
        float posRandom = Random.Range(-10f, 10f);
        float posRandom2 = Random.Range(-10f, 10f);
        Vector3 DestPos = new Vector3(posRandom, 0, posRandom2);
        Vector3 NewPos = RefPos.position + DestPos;
        Instantiate(MyColumn, NewPos, Quaternion.identity);
        nColumnas++;
        
        
    }

    IEnumerator ColumnCorrutine()
    {

        for (int n = 0; ; n++)
        {
            CrearColumna();
            if(nColumnas > 5) { yield return new WaitForSeconds(1f); }
            if (nColumnas > 10) { yield return new WaitForSeconds(0.5f); }
            else { yield return new WaitForSeconds(2f);  }
        
            
        }
            
        
    }
}
