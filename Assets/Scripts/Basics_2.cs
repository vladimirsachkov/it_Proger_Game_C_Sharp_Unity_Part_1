using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics_2 : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start");
    }
    private void LateUpdate()
    {
        Debug.Log("Late update");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Update");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
}