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
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(Camera.main);
        LoadingScreen.SetActive(true);
        UIManager.Initilize();
        levelManager.Initilize();
        saveManager.Initilize();
        player.SetActive(true);
        LoadingScreen.SetActive(false);
    }
}
