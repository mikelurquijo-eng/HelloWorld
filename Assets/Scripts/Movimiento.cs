using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }
}
