using UnityEngine;

[CreateAssetMenu(menuName = "TextCuento")]
public class TextCuentos : ScriptableObject
{
    [TextArea(2, 4)]
    public string textDiapositiva;  
}
