using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds functions to be executed.
/// </summary>
public class FunctionRepository : MonoBehaviour
{

    public static void Create(Vector3 position, Color color, GameObject obj)
    {
        var go = GameObject.Instantiate(obj, position, Quaternion.identity);
        go.GetComponent<MeshRenderer>().material.color = color;
    }
}
