using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //definimos las camras a urilizar
    public Camara camaraAerea;
    public Camara camaraPlayer;
    // Definimos la velocidad de desplazamiento
   public float velocidad = 1.0f;
   //Definimos el target hacia el cual apunta la camara
   public Trasform destino;
   //Definimos el tiempo en el cual se afectua el desplazamiento
   public float timer = 10.0f;


    void Start()
    {
        //Activamos camara aerea al inicio y desactivamos la camara del jugador
        camaraAerea.enable = true;
        camaraPlayer.enable = false;

        
    }

    
    void Update()
    {
        //Efectuamos un seguimiento del destino (player) apuntando la camara aerea
        if(destino !=null){
            //Seguimos al destino segun su posicion(player)
            Trasform.LookAt(destino);
            //Definimos la distancia del destino
            Vector3 distancia = (destino.position - Trasform.position).normalized;
            //Desplazamiento hacia el player(destino o target)
            trasform.Translate(distancia * velocidad * Time.deltaTime,Space.World)
        }
        //Actualizamos timer
        timer -= Time.deltaTime;
        //Establecemos la configuracion del timer para el desplazamiento
        if(timer <= 0)
        {
            //Desactuvamos camara aerea y habilitamos camara de player
            camaraAerea.enable = false;
            camaraPlayer.enable = true;
            //Desactivamos este script
            this.enable = false;    
        }
    }
}
