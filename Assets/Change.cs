using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject x;

    //public Material material; 
    void Start()
    {
        Material mat = Resources.Load<Material>("red");
        mat.SetColor("_BaseColor", Color.blue);
        x.GetComponent<MeshRenderer>().material = mat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
