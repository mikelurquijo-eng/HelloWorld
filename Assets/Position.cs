using UnityEngine;

public class Position : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionLogTrace();
    }

    private void positionLogTrace() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("The position in the X axis is: " + gameObject.transform.position.x
                + "The position in the Y axis is: " + gameObject.transform.position.y
                + "The position in the Z axis is: " + gameObject.transform.position.z);
        }
    }
}
