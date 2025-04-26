using System;
using System.Collections;
using UnityEngine;

public class CreateObject9 : MonoBehaviour
{
    
    public GameObject[] obj;

    public void Start()
    {
        // Start_1();
        // Start_2();
    }

    private void Update()
    {
        Update_2();
    }

    private void Update_1()
    {
        if (Input.GetKeyDown(KeyCode.U))
            StartCoroutine(Create3dObjects(2f));
    }
    
    private void Update_2()
    {
        if (Input.GetKeyDown(KeyCode.U))
            StartCoroutine(Create3dObjectLoop(2f));
    }
    
    public void Start_2()
    {
        // StartCoroutine(Create3dObjects());
    }

    public void Start_1()
    {
        Invoke("Create", 2f);
    }


    // Start is called before the first frame update
    void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)],
                new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));
        }
        // GameObject newObject = 
        //     Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
        // newObject.GetComponent<Transform>().position = new Vector3(5, 5, 0);
    }

    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0, 10);
    }

    private IEnumerator Create3dObjects(float wait)
    {
        yield return new WaitForSeconds(wait);
        Create();
        Debug.Log("Start");
    }
    
    private IEnumerator Create3dObjectLoop(float wait)
    {
        while (true)
        {
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)],
                    new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));
            yield return new WaitForSeconds(wait);
        }
    }
}
