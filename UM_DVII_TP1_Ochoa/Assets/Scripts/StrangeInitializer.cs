using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class StrangeInitializer : ContextView
{

    // Use this for initialization
    void Start()
    {
        context = new MyContext(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
