using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ellipse3 : MonoBehaviour
{

    int segments = 3600;
    public float xAxis = 10f;
    public float yAxis = 5f;
    public LineRenderer lr;
    public int ind = 0;


    public int del = 0;
    public GameObject orbitingObject;
    public int startsegemnt;
    public int period = 88;
    public bool orbitActive = true;
    Vector3[] points = new Vector3[3601];
    void Start()
    {
        CalculateEllipse();
        StartCoroutine("Movement");


    }

    void CalculateEllipse()
    {
        for (int i = 0; i < segments; i++)
        {
            float angle = ((float)i / (float)segments) * 360 * Mathf.Deg2Rad;
            float x = Mathf.Sin(angle) * xAxis;
            float y = Mathf.Cos(angle) * yAxis;
            points[i] = new Vector3(x, y, 0f);
        }
        points[segments] = points[0];

        lr.positionCount = segments + 1;
        lr.SetPositions(points);

    }
    /* void OnValidate()
     {   if(Application.isPlaying)
         CalculateEllipse();
     }
     */



    public void StopMove()
    {
        orbitActive = false;
    }
    public void StartMove()
    {
        orbitActive = true;
        StartCoroutine("Movement");
    }
    // Update is called once per frame
    IEnumerator Movement()
    {
        while (orbitActive == true)
        {
            ind = 3600 / period * (del % period);
            float x = points[ind].x;
            float y = points[ind].y;
            orbitingObject.transform.position = new Vector3(x, y, 0);
            del += 1;
            orbitingObject.transform.Rotate(0, 1, 0);
            yield return new WaitForSeconds(.1f);
        }

    }
}
