using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GameObject Second, Third;
    static public GameObject First; // Static reference

    public int x = 0;
    public Text Mytxt;
    static public int y;
    static public int z;
    static public int c;
    public float[] numbers;

    void Start()
    {
        numbers = new float[] {1, 2, 5, 6, 9};

        // Assign this object or another object as First, if not assigned elsewhere
        if (First == null)
        {
            First = this.gameObject;
        }
    }

    void Update()
    {
        if (x >= 1000)
        {
            this.gameObject.SetActive(false);
        }
        Mytxt.text = x.ToString();
    }

    public void OnTriggerStay(Collider other){
        z = Random.Range(0, 255);
        c = Random.Range(0, 255);
        y = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)Test.z, (byte)Test.y, (byte)Test.c, 255);
    }

}
