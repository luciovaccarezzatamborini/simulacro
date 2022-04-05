using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float cap1 = 11;
    public float cap2 = 22;
    public float cap3 = 33;

    float montototal;
    float porcentaje1 = 1;
    float porcentaje2 = 2;
    float porcentaje3 = 3;

    // Start is called before the first frame update
    void Start()
    {
        montototal = cap1 + cap2 + cap3;
        Debug.Log("Nombre: " + nombre3 + " capital tado: $" + cap3 + " Porcentaje del capital: %" + porcentaje3 + " Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + nombre2 + " capital tado: $" + cap2 + " Porcentaje del capital: %" + porcentaje2 + " Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + nombre1 + " capital tado: $"  + cap1 + " Porcentaje del capital: %" + porcentaje1 +" Monto total aportado: $" + montototal);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
