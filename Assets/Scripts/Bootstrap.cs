using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] LevelManager levelManager;
    [SerializeField] SaveManager saveManager;
    [SerializeField] UIManager UIManager;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        levelManager.Initilize();
        saveManager.Initilize();
        UIManager.Initilize();
    }
}
