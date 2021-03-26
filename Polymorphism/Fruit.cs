using UnityEngine;
using System.Collections;

public class Fruit
{
    public Fruit()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}