using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorStats : Singleton<EditorStats>
{
    private States currentState;

    public static States CurrentState { get => Instance.currentState; }

    public static void TryToChangeState(States newState)
    {
        bool permissionGranted = false;

        if(CurrentState != newState)
        {
            permissionGranted = true;
        }

        switch(newState)
        {
            case States.Menu:
                {
                    if(permissionGranted)
                    {

                    }
                    break;
                }
            case States.Edit:
                {
                    if(permissionGranted)
                    {

                    }
                    break;
                }
            case States.Quit:
                {
                    if(permissionGranted)
                    {

                    }
                    break;
                }
        }
        if(permissionGranted)
        {
            Instance.currentState = newState;
        }
    }
}

public enum States
{
    Menu,
    Edit,
    Quit
}