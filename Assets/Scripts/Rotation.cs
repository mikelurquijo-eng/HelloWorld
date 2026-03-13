using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            gameObject.transform.rotation *= Quaternion.Euler(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.rotation *= Quaternion.Euler(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.rotation *= Quaternion.Euler(0, 0, 1);
        }
    }
}
