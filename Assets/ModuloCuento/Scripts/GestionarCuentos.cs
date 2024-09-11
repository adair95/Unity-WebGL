using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GestionarCuentos : MonoBehaviour
{
    [SerializeField] TextCuentos textCuentos;
    [SerializeField] List<AudioClip> audioClip = new List<AudioClip>();
    [SerializeField] AudioSource audioSource;
    [SerializeField] private TextMeshProUGUI textReferencia; //Referencia al texto de la UI
    [SerializeField] List<TextCuentos> cuentos;
    [SerializeField] List<GameObject> gameObjects;
    [SerializeField] List<TextCuentos> cargaDeCuentos;
    [SerializeField] GameObject btnAtras, grupoDosBtn,adelante;
    GameObject fond;
    [SerializeField] int numeroDeCuentos;
    [SerializeField] Button btnSonido;
    [SerializeField] bool sonidoBtn = true;

    private TextCuentos gestionarIndex;

    private int contador;
    Dictionary<int, List<TextCuentos>> cuentosDict = new Dictionary<int, List<TextCuentos>>();
  
    public int Contador { get => contador; set => contador = value; }
    public TextCuentos GestionarIndex { get => gestionarIndex; set => gestionarIndex = value; }
    public bool SonidoBtn { get => sonidoBtn; set => sonidoBtn = value; }

    private void Awake()
    {
       // GameController.gameController.PausarMusica();
        cuentosDict.Add(0, cuentos);
        cargaDeCuentos = cuentosDict[0];

        audioSource = GetComponent<AudioSource>();
        btnAtras.SetActive(false);

        textCuentos = cargaDeCuentos[0];
        textReferencia.text = textCuentos.textDiapositiva;
       
    }
    private void Start()
    {
       UnPause();
    }
    private void Update()
    {
        if (Contador == 0)
        {
            btnAtras.SetActive(false);
        }
        else
        {
            if (Contador == numeroDeCuentos)
            {
                grupoDosBtn.SetActive(false);
                adelante.SetActive(true);
            }
        }
    }

    public void Siguiente()
    {
        try
        {
            GestionarIndex = cuentos[cuentos.Count - 1];
            int indexUltimoElemento = cuentos.LastIndexOf(GestionarIndex);

            if (Contador == indexUltimoElemento)
            {
                textCuentos = cuentos[Contador];
                Debug.Log(" felicidades a terminado los audiocuentos");
            }
            else
            {
                Contador++;
               
              
                fond = gameObjects[Contador];
               
                fond.SetActive(true);
                textCuentos = cuentos[Contador];
                textReferencia.text = textCuentos.textDiapositiva;
                btnAtras.SetActive(true);
                PausaSonido();
                VerificarSonidoBtn();
              
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }
    public void Atras()
    {
        try
        {
            GestionarIndex = cuentos[cuentos.Count - 1];
            int indexUltimoElemento = cuentos.LastIndexOf(GestionarIndex);

            Contador--;
           
            fond.SetActive(false);
            fond = gameObjects[Contador];
            
            textCuentos = cuentos[Contador];

            textReferencia.text = textCuentos.textDiapositiva;
            PausaSonido();
            VerificarSonidoBtn();
         
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void UnPause()
    {
        if (SonidoBtn == false)
        {
            PausaSonido();
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            else
            {
                AudioClip gestionarAudioClip = audioClip[Contador];
                AudioClip repoducir = audioSource.clip = audioClip[Contador];
                audioSource.PlayOneShot(repoducir);
            }
            
        }
       
    }
    private void PausaSonido()
    {
        AudioClip repoducir = audioSource.clip = audioClip[Contador];

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    public void GestionarAudios()
    {
       
        if (SonidoBtn) //SonidoBtn es True, cambia icono BTN y pausa el sonido
        {
            btnSonido.image.sprite = Resources.Load<Sprite>("Sprites/Botones/SINSONIDO");
            PausaSonido();
            SonidoBtn = false;
        }
        else
        {
            UnPause();
            btnSonido.image.sprite = Resources.Load<Sprite>("Sprites/Botones/sonido");
            SonidoBtn = true;
        }
    }

    private void VerificarSonidoBtn()
    {
        if (SonidoBtn == false)
        {
            PausaSonido();
        }
        else
        {
            UnPause();
        }
    }
}
