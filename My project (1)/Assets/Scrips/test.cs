using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public GameObject Test;
    public int x = 0;
    public Text Mytxt;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        if(x >= 1000){
            Test.SetActive(false);
        }
        Mytxt.text = x.ToString();
    }
}
