using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScripts : MonoBehaviour
{
    public enum EName
    {
        Jen,
        Marc,
        jose
    }
    public EName name = EName.jose;
    // Start is called before the first frame update
    void Start()
    {
        switch(name)
        {
            case EName.Jen: Debug.Log("My name is Jen");break;
            case EName.Marc: Debug.Log("My name is Marc");break;
            case EName.jose: Debug.Log("My name is Jose");break;
            default: Debug.Log("I do not know your name"); break;
        }
       /* string name = "Marc";
        if (name == "James")
        {
            Debug.Log("My name is James");

        }
        else if (name== "Marc")
        {
            Debug.Log("My name is Marc");
        }
        else
        {
            Debug.Log("I do not know your name");
        }
        switch(name)
        {
            case "James": Debug.Log("My name is James"); break;
            case "Marc": Debug.Log("My name is Marc"); break;
            default: Debug.Log("I do not know your name");break;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
