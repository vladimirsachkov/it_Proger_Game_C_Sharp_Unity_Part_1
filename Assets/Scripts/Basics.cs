using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Basics : MonoBehaviour
{
    [NonSerialized] public int _nums = 3;
    public string word;
    [SerializeField] private float nums;

    public int[] numbers = new int[3];

    public List<string> list = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        if (nums != 5) {
            Info();
        }
    }

    void Info() 
    {
        Debug.Log(word + nums);
    }
}
