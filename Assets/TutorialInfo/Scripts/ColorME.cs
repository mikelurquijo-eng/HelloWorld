using UnityEngine;

public class ColorME : MonoBehaviour
{
    public Color myColor = Color.pink;
    [SerializeField] private Color myColor2 = Color.white;
    private Color lastColorUSed = Color.pink;
    MeshRenderer myRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        myRenderer.material.color = myColor;

    }
}
