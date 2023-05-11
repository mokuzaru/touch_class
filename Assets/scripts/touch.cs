using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Llamar la libreria de Interfaz de usuario
using UnityEngine.UI;
using TMPro;

public class touch : MonoBehaviour
{
    
    public TMP_Text posicion;
    // Vamos a imprimir en consola la posicion del touch desde el dispositivo movil conectado por usb

    void Update()
    {
        //Primero creamos una estructura "if" para determinar si se esta haciendo uso del touch 
        if(Input.touchCount > 0){
            //Creamos una variable de tipo "touch"
            Touch touch = Input.GetTouch(0);
            //mostramos la posicion del touch
            Debug.Log("Posicion touch: " + touch.position);
            //
            posicion.text = "Pos touch: " + touch.position;
        }else{
            Debug.Log("No touch find");
        }    
    }
}
