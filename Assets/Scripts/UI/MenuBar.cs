using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBar : MonoBehaviour
{
    [BoxGroup("Data")]
    [SerializeField] GameObject data, dataBar;

    private bool isOpen = false;

    private MenuBars currentBar = MenuBars.None;

    public void ChangeMenuPanelIsOpen()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            SwitchPanel(MenuBars.Data);
        }
        else
        {
            CloseAllPanel();
            currentBar = MenuBars.None;
        }
    }

    private void SwitchPanel(MenuBars newBar)
    {
        if (currentBar != newBar)
        {
            CloseAllPanel();

            switch (newBar)
            {
                case MenuBars.Data:
                    {
                        dataBar.SetActive(true);
                        break;
                    }
            }
        }
    }

    public void PointerDataPanelEnter()
    {
        if (isOpen)
        {
            SwitchPanel(MenuBars.Data);
        }
    }

    private void CloseAllPanel()
    {
        dataBar.SetActive(false);
    }
}

public enum MenuBars
{
    None,
    Data
}