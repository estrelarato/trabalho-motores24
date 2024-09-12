using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;
    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtraiMoedas(1);
           
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * velocidadeGiro * Time.deltaTime, Space.World);
    }
}
