using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, victory;
    public int restantes;
   
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"moedas: {restantes}";
       
    }
   
    public void SubtraiMoedas(int valor)

    {
        restantes -= valor;
        hud.text = $"moedas: {restantes}";

            if (restantes <= 0)
        {
            //ganhou o game ne pai
            victory.text = "Parabens!!!";
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
