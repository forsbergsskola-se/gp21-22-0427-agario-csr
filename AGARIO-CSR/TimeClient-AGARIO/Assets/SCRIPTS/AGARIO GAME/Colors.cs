using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Colors : MonoBehaviour
{
    public List<Material> Mats = new List<Material>();

    void Awake()
    {
        GetComponent<Renderer>().material = Mats[Random.Range(0, Mats.Count)];
    }
}
