using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeClass : MonoBehaviour
{
    void Start()
    {
        //This is how you create a list. Notice how the type
        //is specified in the angle brackets (< >).
        List<BadGuy> badguys = new List<BadGuy>();

        //Here you add 3 BadGuys to the List
        badguys.Add(new BadGuy("Harvey", 50));
        badguys.Add(new BadGuy("Magneto", 100));
        badguys.Add(new BadGuy("Pip", 5));

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        //This clears out the list so that it is
        //empty.
        badguys.Clear();
    }
}
