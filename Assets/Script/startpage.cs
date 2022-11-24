using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startpage : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("RocketScene");
    }


}
