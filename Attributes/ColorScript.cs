using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{
    void Start()
    {
        renderer.sharedMaterial.color = Color.red;
    }
}
