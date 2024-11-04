using UnityEngine;

public class Rest : MonoBehaviour
{
    // Optional public reference to First GameObject if it needs to be assigned in Inspector
    public GameObject firstObject;

    void Start()
    {
        // Initialize Test.First with a reference from the Inspector if needed
        if (firstObject != null)
        {
            Test.First = firstObject;
        }
    }

    public void ClickBut()
    {
        

        if (Test.First != null)
        {
            Test.First.GetComponent<Renderer>().material.color = new Color32((byte)Test.z, (byte)Test.y, (byte)Test.c, 255); // Opaque
        }
        else
        {
            Debug.LogError("First GameObject is not assigned or is missing a Renderer component.");
        }
    }
}
