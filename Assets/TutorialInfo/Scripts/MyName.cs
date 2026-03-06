using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello my name is Pepe the " + gameObject.name + " y estoy en " + gameObject.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
