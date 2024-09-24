using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeLayout : MonoBehaviour
{
    public RectTransform content; // Asigna el Content del Scroll Rect
    public float itemWidth = 100f; // Ancho de cada ítem
    public float itemHeight = 100f; // Alto de cada ítem
    public float spacing = 20f; // Espacio entre ítems

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

        // Ajusta la posición de cada ítem
        for (int i = 0; i < childCount; i++)
        {
            RectTransform rt = content.GetChild(i).GetComponent<RectTransform>();

            // Ajusta la posición en función del patrón serpenteante
            rt.anchoredPosition = new Vector2(currentX, currentY);
            rt.sizeDelta = new Vector2(itemWidth, itemHeight);

            // Actualiza la posición para el próximo ítem
            if (moveRight)
            {
                currentX += itemWidth + spacing;
            }
            else
            {
                currentX -= itemWidth + spacing;
            }

            // Cambia la dirección después de cada ítem en la misma fila
            moveRight = !moveRight;
            // Actualiza la posición Y para el próximo ítem en la siguiente fila
            if (i % 2 == 1) // Asumiendo que hay 2 ítems por fila
            {
                currentY -= itemHeight + spacing;
            }
        }

        // Ajusta el tamaño del Content para que pueda desplazar todos los ítems
        float totalWidth = Mathf.Abs(currentX) + itemWidth;
        float totalHeight = Mathf.Abs(currentY) + itemHeight;
        content.sizeDelta = new Vector2(totalWidth, totalHeight);
    }
}
