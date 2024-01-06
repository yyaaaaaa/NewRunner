using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : Singleton<SaveManager>
{
    private int coins = 0;
    private int level = 1;
    private int playingFirstTime = 0; // 0 = не играл, 1 = играл 
    public List<TextMeshProUGUI> leveltexts;
    public TextMeshProUGUI cointext;
    public TextMeshProUGUI rewardext;
    public override void Initilize()
    {
        base.Initilize();
        Load();
        ChangeScene();
    }

    public int GetCoins()
    {
        return coins;
    }
    public int GetLevel()
    {
        return level;
    }
    public void ChangeCoins(int amount)
    {
        coins += amount;
    }
    public void ChangeLevel(int amount)
    {
        level += amount;
        if (level >= 5)
        {
            level = 1;
        }
        foreach(var item in leveltexts)
        {
            item.text = "Level " + level;
        }
        cointext.text = coins.ToString();
    }
    public void Save()
    {
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("firstTime", playingFirstTime);
        PlayerPrefs.Save();
    }

    private void Load()
    {
        playingFirstTime = PlayerPrefs.GetInt("firstTime");

        if (playingFirstTime == 1)
        {
            coins = PlayerPrefs.GetInt("coins");

            level = PlayerPrefs.GetInt("level");
            if (level >= 5)
            {
                level = 1;
            }
             
        }
        else
        {
            playingFirstTime = 1;
        }

        foreach (var item in leveltexts)
        {
            item.text = "Level " + level;
        }
        cointext.text = coins.ToString();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(level);
    }

    public void ChangeRewardText(int amount)
    {
        rewardext.text = "+ " + amount.ToString();
    }
}




