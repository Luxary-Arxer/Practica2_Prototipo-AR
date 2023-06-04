using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cargador : MonoBehaviour
{
    public GameObject PantallaCarga;
    public Slider Barra;
    public void CargarEscena (int NumeroDeEscena)
    {
        StartCoroutine(CargarAsync(NumeroDeEscena));
    }

    IEnumerator CargarAsync(int NumeroDeEscena)
    {
        AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);

        PantallaCarga.SetActive(true);

        while (!Operacion.isDone)
        {
            float Progreso = Mathf.Clamp01(Operacion.progress / .9f);
            Barra.value = Progreso;

            yield return null;
        }
    }
}
