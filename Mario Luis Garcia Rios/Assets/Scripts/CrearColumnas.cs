using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearColumnas : MonoBehaviour
{
    public GameObject MyColumn;
    [SerializeField] Transform RefPos;
    [SerializeField] Text timeText;
    public Text numeroCol;
    Vector3 NewPos;
    public int nColumnas;
    

    // Start is called before the first frame update
    void Start()
    {
        nColumnas = 0;
        StartCoroutine("ColumnCorrutine");
    }

    // Update is called once per frame
    void Update()
    {
        double timePass = Time.time;
        string total = timePass.ToString("f0");
        timeText.text = total;
        numeroCol.text = nColumnas.ToString("f0");
    }

    void CrearColumna()
    {
        RefPos = MyColumn.GetComponent<Transform>();
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
