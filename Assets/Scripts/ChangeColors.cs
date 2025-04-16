using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{

    private MeshRenderer _mesh;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            _mesh.material.color = Color.green;
        
        if (Input.GetKeyDown(KeyCode.R))
            _mesh.material.color = Color.red;
        
        if (Input.GetKeyDown(KeyCode.B))
            _mesh.material.color = Color.blue;
    }
}
