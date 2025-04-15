using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    
    public GameObject[] obj;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(obj[Random.Range(0, obj.Length)],
                new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));
        }
        // GameObject newObject = 
        //     Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
        // newObject.GetComponent<Transform>().position = new Vector3(5, 5, 0);
    }

    private int RandomNumber()
    {
        return Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
