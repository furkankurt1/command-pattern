using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandBuffer : MonoBehaviour
{
    public static Queue<ICommand> commandList;

    private void Awake()
    {
        commandList = new Queue<ICommand>();
    }

    public static void AddList(ICommand command)
    {
        commandList.Enqueue(command);
    }


    private void Update()
    {
        if (commandList.Count > 0)
        {
            commandList.Dequeue().Execute();
        }
    }
}
