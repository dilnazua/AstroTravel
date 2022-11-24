using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject SelectButton;
    public GameObject PanelOp;
    // Start is called before the first frame update
    public void OpenPanel()
    {
        SelectButton.SetActive(false);
        PanelOp.SetActive(true);
    }
    public void ClosePanel()
    {
        PanelOp.SetActive(false);
        SelectButton.SetActive(true);
    }
}
