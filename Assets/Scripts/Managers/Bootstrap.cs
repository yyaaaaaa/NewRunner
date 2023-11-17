using System.Collections;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] LevelManager levelManager;
    [SerializeField] SaveManager saveManager;
    [SerializeField] UIManager UIManager;
    [SerializeField] GameObject LoadingScreen;
    [SerializeField] GameObject player;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(Camera.main);
        LoadingScreen.SetActive(true);
        UIManager.Initilize();
        levelManager.Initilize();
        saveManager.Initilize();
        player.GetComponent<PlayerLogic>().Initilize();
        LoadingScreen.SetActive(false);
    }
}
