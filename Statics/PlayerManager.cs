using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        //You can access a static variable by using the class name
        //and the dot operator.
        int x = Player.playerCount;
    }
}
