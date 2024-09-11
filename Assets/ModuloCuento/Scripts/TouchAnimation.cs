using UnityEngine;

public class TouchAnimation : MonoBehaviour
{
    [SerializeField] Animator animator; 
    [SerializeField] GameObject boton, groupBoton;
    [SerializeField] Movimientofondo movimientoFondo;
    public bool verificarestadoAnimator = false;
    public bool VerificarestadoAnimator { get => verificarestadoAnimator; set => verificarestadoAnimator = value; }
 

    private void Awake()
    {
       animator = GetComponent<Animator>();
    }

    public void SetAnimaciones(string animaciones)
    {
        if (!verificarestadoAnimator)
        {
             animator.Play(animaciones);

            VerificarestadoAnimator = true;
        }
        else
        {
            animator.Rebind();
            animator.Play(animaciones);
        }
    }
      
    public void ActivarBoton()
    {
        
        boton.SetActive(true);
        groupBoton.SetActive(true);
    }

    public void IniciarMovimientoDeFondo()
    {
        if (movimientoFondo != null)
        {
            movimientoFondo.IniciarAnimacionConParallax();
        }
    }
    public void PararMovimientoDeFondo()
    {
        if (movimientoFondo != null)
        {
            movimientoFondo.PararParallax();
            movimientoFondo.OffsetCero();
        }
    }
}
