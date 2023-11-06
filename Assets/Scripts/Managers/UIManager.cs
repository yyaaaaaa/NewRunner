using System;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    private string currentName;
    private GameObject currentGO;
    public List<Container> containersList = new();
    Dictionary<string, GameObject> containers = new();
    public bool isPlaying = false;
    public PlayerLogic player;

    public override void Initilize()
    {
        base.Initilize();
        DontDestroyOnLoad(containersList[0].container.transform.parent);
        DontDestroyOnLoad(player.gameObject);
        foreach (var kvp in containersList)
        {
            containers[kvp.name] = kvp.container;
        }

        isPlaying = false;
        currentName = "MainMenu";
        WorkWithContainer(currentName , true);
    }

    public void StartGame()
    {
        isPlaying = true;
        WorkWithContainer(currentName, false);
        currentName = "Game";
        WorkWithContainer(currentName, true);
    }

    public void LoseLevel()
    {
        isPlaying = false;
        WorkWithContainer(currentName, false);
        currentName = "LoseLevel";
        WorkWithContainer(currentName, true);
        player.Reset();
        SaveManager.instance.ChangeScene();
    }

    public void CompleteLevel()
    {
        isPlaying = false;
        WorkWithContainer(currentName, false);
        currentName = "CompleteLevel";
        WorkWithContainer(currentName, true);
        player.Reset();
        int reward = UnityEngine.Random.Range(100, 500);
        SaveManager.instance.ChangeRewardText(reward);
        SaveManager.instance.ChangeCoins(reward);
        SaveManager.instance.ChangeLevel(1);
        SaveManager.instance.Save();
        SaveManager.instance.ChangeScene();
    }

    public void NextLevel()
    {
        WorkWithContainer(currentName, false);
        currentName = "MainMenu";
        WorkWithContainer(currentName, true);
    }


    private void WorkWithContainer(string name, bool enable)
    {      
        containers.TryGetValue(name, out currentGO);
        if (enable)
        {
            currentGO.SetActive(true);
        }
        else
        {
            currentGO.SetActive(false);
        }
    }

    [Serializable]
    public class Container
    {
        public string name;
        public GameObject container;
    }
}
