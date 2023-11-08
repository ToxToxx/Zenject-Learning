using Zenject;
using UnityEngine;

public class ExampleOfIInitializable : IInitializable
{
    public void Initialize()
    {
        Debug.Log("I initialize");
    } 
}
