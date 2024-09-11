using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimientofondo : MonoBehaviour
{
    [SerializeField] Vector2 speed;
    private Vector2 speedMax;
    private Vector2 offset;
    private Material material;
    public bool movimientoDerecha = true; // Bandera para controlar la dirección del movimiento
    public bool activar = false;
    private void Awake()
    {
        material = GetComponent<Image>().material;
        speedMax = speed;
    }

    void Start()
    {
        // Ajustar la velocidad del parallax
        speedMax = new Vector2(0.0f, 0.0f);
    }

    void Update()
    {

        if (activar == true)
        {
            SpeedFondo();
        }
    }

    void SpeedFondo()
    {
        float xOffset = movimientoDerecha ? speedMax.x : -speedMax.x; // Cambiar el offset según la dirección
        offset = new Vector2(xOffset, 0.0f) * Time.deltaTime;
        material.mainTextureOffset += offset;
    }

    public void IniciarAnimacionConParallax()
    {
        // Activar el parallax
        activar = true;

        speedMax = speed;
    }

    public void PararParallax()
    {
        // Detener el parallax
        activar = false;
        speedMax = new Vector2(0.0f, 0.0f);
    }
    // convertir el offset a cero
    public void OffsetCero()
    {
        material.mainTextureOffset = new Vector2(0.0f, 0.0f);
    }
}

