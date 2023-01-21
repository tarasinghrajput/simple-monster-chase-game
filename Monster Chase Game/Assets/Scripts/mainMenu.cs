using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        int selectedChar = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManagerScript.instance.CharIndex = selectedChar;
    }
}
