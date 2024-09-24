using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeLayout : MonoBehaviour
{
    public RectTransform content; // Asigna el Content del Scroll Rect
    public float itemWidth = 100f; // Ancho de cada �tem
    public float itemHeight = 100f; // Alto de cada �tem
    public float spacing = 20f; // Espacio entre �tems

    void Start()
    {
        ArrangeItems();
    }

    void ArrangeItems()
    {
        int childCount = content.childCount;
        float currentX = 0f;
        float currentY = 0f;
        bool moveRight = true; // Indica si mover a la derecha o a la izquierda

        // Ajusta la posici�n de cada �tem
        for (int i = 0; i < childCount; i++)
        {
            RectTransform rt = content.GetChild(i).GetComponent<RectTransform>();

            // Ajusta la posici�n en funci�n del patr�n serpenteante
            rt.anchoredPosition = new Vector2(currentX, currentY);
            rt.sizeDelta = new Vector2(itemWidth, itemHeight);

            // Actualiza la posici�n para el pr�ximo �tem
            if (moveRight)
            {
                currentX += itemWidth + spacing;
            }
            else
            {
                currentX -= itemWidth + spacing;
            }

            // Cambia la direcci�n despu�s de cada �tem en la misma fila
            moveRight = !moveRight;
            // Actualiza la posici�n Y para el pr�ximo �tem en la siguiente fila
            if (i % 2 == 1) // Asumiendo que hay 2 �tems por fila
            {
                currentY -= itemHeight + spacing;
            }
        }

        // Ajusta el tama�o del Content para que pueda desplazar todos los �tems
        float totalWidth = Mathf.Abs(currentX) + itemWidth;
        float totalHeight = Mathf.Abs(currentY) + itemHeight;
        content.sizeDelta = new Vector2(totalWidth, totalHeight);
    }
}
