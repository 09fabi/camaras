using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    //Creamos una referencia a canvas tiempo agotado
   public GameObject canvasTiempo;
    //Definimos el tiempo para llegar a la meta
    public float timerEscena = 30.0f
    //Referencia a camara de player
    public Camera camaraPlayer;
    //Audio source game over
    public AudioSource audioGameOver;
    //Audio source background
    public AudioSource audioBackground;


    //Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
            //Verificamos si la camara player esta activa
            if(camaraPlayer.enabled){
            Debug.log("Camara player habilitada");
             //Actualizamos el timer
            timerEscena -= Time.deltaTime;
            //Verificamos si se acabo el tiempo
            if(timerEscena <=0)
            {
            //Activamos canvas de tiempo
            canvas.Tiempo.SetActive(true);
             //Detener sonido Background
            audioBackground.Stop();
            //Ejectutar sonido alusivo
            audioGameOver.Play();
            }
        }
        else
        {   
            Debug.log("Camara player deshabilitada");
        }
    }
}