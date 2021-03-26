using UnityEngine;
using System.Collections;

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        //In order to create an object of a generic class, you must
        //specify the type you want the class to have.
        GenericClass<int> myClass = new GenericClass<int>();

        myClass.UpdateItem(5);
    }
}
