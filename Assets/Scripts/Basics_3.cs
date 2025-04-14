using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics_3 : MonoBehaviour
{

    public GameObject[] objs = new GameObject[3];
    public Transform target;
    public BoxCollider Box;
    public Light _light;
    
    public Transform[] transforms = new Transform[3];

    public float speed = 5.0f, rotateSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Start_1()
    {
        //obj.SetActive(false);
        //obj.GetComponent<Transform>()
        //    .position = new Vector3(10, 0, 5);
        target.position = new Vector3(10, 0, 5);
        _light.intensity = 0.5f;

        for (int i = 0; i < objs.Length; i++)
        {
            objs[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] == null)
                continue;
            
            transforms[i].Translate(new Vector3(-1,0,0) * (speed * Time.deltaTime));
            transforms[i].Rotate(new Vector3(-1, 0, 0) * (rotateSpeed * Time.deltaTime));
            float posX = transforms[i].position.x;
            if (posX < -10f) 
                Destroy(transforms[i].gameObject);
        }
    }
}
