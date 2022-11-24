using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickViewScript : MonoBehaviour
{

    public Transform target;
    public Camera cam;
    public int zoomsize=10;
    public void CameraZoom()
    {
        cam.transform.position = new Vector3(target.transform.position.x-10, target.transform.position.y, 500);
        cam.orthographicSize = zoomsize;
        cam.transform.rotation = new Quaternion(0f, 180, 0f, 0f);



    }



}
