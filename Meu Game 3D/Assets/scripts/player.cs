using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    public int pulo = 7;
    public bool nochão;
    
    private Rigidbody rb;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!nochão && collision.gameObject.tag == "chão")
        {
            nochão = true;
        }
    }



    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //-1 esqueda, o nada, 1 direita
        float v = Input.GetAxis("Vertical");// -1 tras, 0 nada, 1 pra frente

        UnityEngine.Vector3 direcao = new Vector3(x:h, y:0, z:v);
        rb.AddForce(direcao * velocidade);
        
        if (Input.GetKeyDown(KeyCode.Space) && nochão)
        {
            rb.AddForce(Vector3.up * pulo, ForceMode.Impulse);
            nochão = false;
        }



        if (transform.position.y <= -5)
        {
            //bolacaiu
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
