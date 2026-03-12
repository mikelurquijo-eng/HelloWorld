using Unity.VisualScripting;
using UnityEngine;

public class ColorTheWorld : MonoBehaviour
{
    Object[] allTheGameObjects;
    [Serialize]
    public Color color;

    [Serialize]
    public bool tag;

    [Serialize]
    public string chosenTag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (tag) {
            if (chosenTag.Equals("red"))
            {
                color = Color.red;
            }

            else { 
            
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in allTheGameObjects) {
            if (item.GetComponent<MeshRenderer>())
            {

            }
        }
    }
}
