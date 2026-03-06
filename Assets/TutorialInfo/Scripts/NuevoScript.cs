using UnityEngine;

public class NuevoScript : MonoBehaviour
{
    public int varPublic;
    private int varPrivate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(varPublic);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(varPublic);
    }
}
