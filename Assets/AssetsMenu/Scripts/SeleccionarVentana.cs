using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SeleccionarVentana : MonoBehaviour
{
    public GameObject VentanaCorazon;
    public GameObject VentanaPulmones;
    public GameObject VentanaEstomago;

    Animation AVentanaCorazon;
    Animation AVentanaPulmones;
    Animation AVentanaEstomago;

    bool VisibleVCorazon = false;
    bool VisibleVPulmones = false;
    bool VisibleVEstomago = false;

    void Start()
    {
        AVentanaCorazon = VentanaCorazon.GetComponent<Animation>();
        AVentanaPulmones = VentanaPulmones.GetComponent<Animation>();
        AVentanaEstomago = VentanaEstomago.GetComponent<Animation>();
    }

    public void VentanaCorPulsada()
    {
        if(VisibleVCorazon == false)
        {
            AVentanaCorazon["Corazon"].speed = 1;
            AVentanaCorazon.Play();
            VisibleVCorazon = true;
        }
    }

    public void VentanaPulPulsada()
    {
        if (VisibleVPulmones == false)
        {
            AVentanaPulmones["Pulmones"].speed = 1;
            AVentanaPulmones.Play();
            VisibleVPulmones = true;
        }
    }
    public void VentanaEstPulsada()
    {
        if (VisibleVCorazon == false)
        {
            AVentanaEstomago["Estomago"].speed = 1;
            AVentanaEstomago.Play();
            VisibleVEstomago = true;
        }
    }

    public void VentanaNoPulsada()
    {
        string NombreBoton = EventSystem.current.currentSelectedGameObject.name;

        if (NombreBoton != "Corazon" & VisibleVCorazon == true)
        {
            AVentanaCorazon["Corazon"].speed = -1;
            AVentanaCorazon["Corazon"].time = AVentanaCorazon["Corazon"].length;
            AVentanaCorazon.Play();
            VisibleVCorazon = false;
        }
        if (NombreBoton != "Pulmones" & VisibleVPulmones == true)
        {
            AVentanaPulmones["Pulmones"].speed = -1;
            AVentanaPulmones["Pulmones"].time = AVentanaPulmones["Pulmones"].length;
            AVentanaPulmones.Play();
            VisibleVPulmones = false;
        }
        if (NombreBoton != "Estomago" & VisibleVEstomago == true)
        {
            AVentanaEstomago["Estomago"].speed = -1;
            AVentanaEstomago["Estomago"].time = AVentanaEstomago["Estomago"].length;
            AVentanaEstomago.Play();
            VisibleVEstomago = false;
        }
    }
}


