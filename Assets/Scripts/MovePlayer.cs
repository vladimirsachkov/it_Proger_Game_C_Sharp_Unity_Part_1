using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        //     transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        //
        // if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        //     transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * -speed);
            
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed * v);
        
        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed * h);
    }
}
