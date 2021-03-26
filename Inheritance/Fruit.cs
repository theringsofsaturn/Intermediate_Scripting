using UnityEngine;
using System.Collections;

//This is the base class which is
//also known as the Parent class.
public class Fruit
{
    public string color;

    //This is the first constructor for the Fruit class
    //and is not inherited by any derived classes.
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    //This is the second constructor for the Fruit class
    //and is not inherited by any derived classes.
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}