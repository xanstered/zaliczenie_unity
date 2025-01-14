using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject friendsPanel;
    public GameObject achievementsPanel;
    public GameObject questsPanel;

    public void OpenInventory()
    {
        CloseAllPanels();
        inventoryPanel.SetActive(true);
    }

    public void OpenFriendsPanel()
    {
        CloseAllPanels();
        friendsPanel.SetActive(true);
    }

    public void OpenAchievements()
    {
        CloseAllPanels();
        achievementsPanel.SetActive(true);
    }

    public void OpenQuests()
    {
        CloseAllPanels();
        questsPanel.SetActive(true);
    }

    private void CloseAllPanels()
    {
        inventoryPanel.SetActive(false);
        friendsPanel.SetActive(false);
        achievementsPanel.SetActive(false);
        questsPanel.SetActive(false);
    }
}
