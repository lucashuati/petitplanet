using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControle : MonoBehaviour {

    public void iniciarJogo(string nomeCena)
    {
        Application.LoadLevel(nomeCena);
    }

}
