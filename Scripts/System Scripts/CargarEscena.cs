using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CargarEscena : MonoBehaviour {
   public int numeroEscena = 0;
    public void cambiarEscena(string nombreEscena)
    {
        if (numeroEscena == 1)
        {
            SceneManager.LoadScene(1);
        }
        if(numeroEscena==2)
        {
            SceneManager.LoadScene(2);
        }
        if(numeroEscena==3)
        {
            SceneManager.LoadScene(3);
        }
    }
}
