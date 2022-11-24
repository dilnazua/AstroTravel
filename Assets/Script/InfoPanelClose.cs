using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelClose : MonoBehaviour
{
    public GameObject infoPanel;
    // Start is called before the first frame update
    public void close()
    {
        infoPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
