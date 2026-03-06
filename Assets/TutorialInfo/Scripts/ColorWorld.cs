using UnityEngine;
using UnityEngine.UIElements;

public class ColorWorld : MonoBehaviour
{
    public Color myColor;
    MeshRenderer[] allTheGameObjects;
    GameObject[] arrayObjects; 
    string tag = "Color";
    bool tagColor = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        if (tagColor){
            myColor = Color.red;
            arrayObjects = GameObject.FindGameObjectsWithTag(tag);
        }
        else {
            allTheGameObjects = FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (tagColor)
        {
            foreach (GameObject o in arrayObjects)
            {
                o.GetComponent<MeshRenderer>().material.color = myColor;
            }
        }
        else
        {
            foreach (MeshRenderer o in allTheGameObjects)
            {
                o.material.color = myColor;
            }
        }
        
    }
}
