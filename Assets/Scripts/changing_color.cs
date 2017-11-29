using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changing_color : MonoBehaviour
{

    private GameObject[] White;
    private GameObject[] Orange;
    private GameObject[] Green;
    private GameObject[] Blue;

    // Use this for initialization
    void Awake()
    {
        White = GameObject.FindGameObjectsWithTag("White");
        foreach (GameObject w in White)
        {
            w.SetActive(true);
        }
        Orange = GameObject.FindGameObjectsWithTag("Orange");
        foreach (GameObject o in Orange)
        {
            o.SetActive(false);
        }
        Green = GameObject.FindGameObjectsWithTag("Green");
        foreach (GameObject g in Green)
        {
            g.SetActive(false);
        }
        Blue = GameObject.FindGameObjectsWithTag("Blue");
        foreach (GameObject b in Blue)
        {
            b.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Change To White"))
        {
            foreach (GameObject w in White)
            {
                w.SetActive(true);
            }
            foreach (GameObject o in Orange)
            {
                o.SetActive(false);
            }
            foreach (GameObject g in Green)
            {
                g.SetActive(false);
            }
            foreach (GameObject b in Blue)
            {
                b.SetActive(false);
            }
        }
        if (Input.GetButtonDown("Change To Orange"))
        {
            foreach (GameObject o in Orange)
            {
                o.SetActive(true);
            }
            foreach (GameObject w in White)
            {
                w.SetActive(false);
            }
            foreach (GameObject g in Green)
            {
                g.SetActive(false);
            }
            foreach (GameObject b in Blue)
            {
                b.SetActive(false);
            }
        }
        if (Input.GetButtonDown("Change To Green"))
        {
            foreach (GameObject g in Green)
            {
                g.SetActive(true);
            }
            foreach (GameObject w in White)
            {
                w.SetActive(false);
            }
            foreach (GameObject o in Orange)
            {
                o.SetActive(false);
            }
            foreach (GameObject b in Blue)
            {
                b.SetActive(false);
            }
        }
        if (Input.GetButtonDown("Change To Blue"))
        {
            foreach (GameObject b in Blue)
            {
                b.SetActive(true);
            }
            foreach (GameObject w in White)
            {
                w.SetActive(false);
            }
            foreach (GameObject o in Orange)
            {
                o.SetActive(false);
            }
            foreach (GameObject g in Green)
            {
                g.SetActive(false);
            }
        }
    }
}
    
