using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InputManager : MonoBehaviour
{
    private Camera _camera;
    private RaycastHit hit;
    public GameObject myObject;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                var color = RandomColor();
                ICommand myCommand = new CommandPlace(hit.point, color, myObject);
                CommandBuffer.AddList(myCommand);
            }
        }
    }

    private Color RandomColor()
    {
        return new Color(Random.Range(.5f, 1), Random.Range(.5f, 1), Random.Range(.5f, 1));
    }
}
