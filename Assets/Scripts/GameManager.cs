using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set; }

    private int playerHealth;
    private int playerXP;
    private int difficulty = 5;

    public OptionsManager OptionsManager { get; private set;}
    public AudioManager AudioManager { get; private set;}
    public DeckManager DeckManager { get; private set;}


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeManagers();
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void InitializeManagers()
    {
        OptionsManager = GetComponentInChildren<OptionsManager>();
        AudioManager = GetComponentInChildren<AudioManager>();
        DeckManager = GetComponentInChildren<DeckManager>();

        if (OptionsManager == null)
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/OptionsManager");
        }

    }

    public int PlayerHealth
    {
        get {return playerHealth; }
        set { playerHealth = value; }
    }

    public int PlayerXP
    {
        get {return playerXP; }
        set { playerXP = value; }
    }

    public int Difficulty
    {
        get {return difficulty; }
        set { difficulty = value; }
    }

}
