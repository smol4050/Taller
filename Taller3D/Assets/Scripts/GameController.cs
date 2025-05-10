using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Dictionary<string, int> figurasEnCaja;

    public TextMeshProUGUI textContadorCubos;
    public TextMeshProUGUI textContadorEsferas;
    public TextMeshProUGUI textContadorCapsulas;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        figurasEnCaja = new Dictionary<string, int>()
        {
            { "Cubo", 0 },
            { "Esfera", 0 },
            { "Capsula", 0 }

        };
    }

    public void ActualizarContadores()
    {
        if(textContadorCubos != null)
            textContadorCubos.text = figurasEnCaja["Cubo"].ToString();

        if(textContadorEsferas != null)
            textContadorEsferas.text = figurasEnCaja["Esfera"].ToString();

        if (textContadorCapsulas != null)
            textContadorCapsulas.text = figurasEnCaja["Capsula"].ToString();
    }


}
