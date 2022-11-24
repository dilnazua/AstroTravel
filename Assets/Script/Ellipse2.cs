using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Ellipse2 : MonoBehaviour
{


    int segments=3600;
    public float xAxis = 10f;
    public float yAxis = 5f;
    public LineRenderer lr;
    public string date1 = "ff";
    public GameObject inputFieldDay;
    public GameObject inputFieldMonth;
    public GameObject inputFieldYear;
    public float ind = 0;
    public int del = 0;
    public GameObject orbitingObject;
    public int startsegemnt;
    public int period=1;
    public bool orbitActive = true;
    Vector3[] points = new Vector3[3601];
    void Start()
    {
        lr.material.color = Color.white;
        CalculateEllipse();
        StartCoroutine("Movement");


    }

    void CalculateEllipse()
    {   
        for(int i=0; i < segments; i++) {
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

    public void dateInput()
    {
        date1 = "12.12.2012";

        StopCoroutine("Movement");
        int year = Convert.ToInt32(inputFieldYear.GetComponent<Text>().text);
        int month = Convert.ToInt32(inputFieldMonth.GetComponent<Text>().text);
        int day = Convert.ToInt32(inputFieldDay.GetComponent<Text>().text);

        var date = new System.DateTime(year,month,day);
        var refdate = new DateTime(2020, 9, 11);
        int days = Convert.ToInt32((date - refdate).TotalDays);
        if (days < 0) days = days * -1;
        del = days;
        ind = 3600f / period * ((startsegemnt + del) % period);
        int i = Convert.ToInt32(ind);
        float x = points[i].x;
        float y = points[i].y;
        orbitingObject.transform.position = new Vector3(x, y, 0);


    }

    public void StopMove()
    {  if (orbitActive == true)
            orbitActive = false;
        else { orbitActive = true;
            StartCoroutine("Movement");
        }
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
            ind = 3600f / period * ((startsegemnt+del)%period);
            int i = Convert.ToInt32(ind);
            float x = points[i].x;
            float y = points[i].y;
            orbitingObject.transform.position = new Vector3(x, y, 0);
            del += 1;
            orbitingObject.transform.Rotate(0, 1, 0);
            yield return new WaitForSeconds(.1f);
        }

    }

}
