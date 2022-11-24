using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetFollow : MonoBehaviour
{
    public Button namebtn;
    public Transform planet;
    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {
        namebtn.transform.position = Camera.main.WorldToScreenPoint(planet.position);
    }
}
