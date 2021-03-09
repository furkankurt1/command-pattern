using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is a feature class.
/// </summary>
public class CommandPlace : ICommand
{

    private Color _color;
    private GameObject _myObject;
    private Vector3 _position;

    public CommandPlace(Vector3 position, Color color, GameObject gameObject)
    {
        _position = position;
        _color = color;
        _myObject = gameObject;
    }

    public void Execute()
    {
        FunctionRepository.Create(_position, _color, _myObject);
    }
}
