using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InfoPanel : MonoBehaviour
{
    public string mainInfo;
    public string planetName;
    public TextMeshPro PlanetNameField;
    public TextMeshPro MainInfoField;
    // Start is called before the first frame update
    public void SetText()
    {
        PlanetNameField.text = planetName;
        MainInfoField.text = mainInfo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
