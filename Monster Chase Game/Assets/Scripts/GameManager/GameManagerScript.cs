using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;

    [SerializeField]
    private GameObject[] characters;

    private int _charIndex;
    public int  CharIndex
    {
        get {return _charIndex;}
        set {_charIndex = value;}
    } 


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    

    // private void OnEnable()
    // {
    //     SceneManager.sceneLoaded += OnLevelFinishedLoading;
    // }

    // private void OnDisable()
    // {
    //     SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    // }


    // void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    // {
    //     if(scene.name == "Gameplay")
    //     {
    //         Instantiate(characters[CharIndex]);
    //     }
    // }
}
