using UnityEngine;

public class Scaling : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            gameObject.transform.localScale += Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            gameObject.transform.localScale += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            gameObject.transform.localScale += Vector3.left * Time.deltaTime;
        }
        
    }
}
