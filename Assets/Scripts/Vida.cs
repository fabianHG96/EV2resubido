using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float valor = 75;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RecibirDa�o(float da�o)
    {
        valor -= da�o;
        if (valor < 0)
        {
            valor = 0;
        }
    }
}
