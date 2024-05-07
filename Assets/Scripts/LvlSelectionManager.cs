using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelectionManager : MonoBehaviour
{
    public LevelObject[] levelObjects;
    [SerializeField] private int MainMenuSceneIndex = 0;
    public static int currlvl;
    public static int UnlockedLvl;

    void Start()
    {
        UnlockedLvl = PlayerPrefs.GetInt("UnlockedLvl", 0);
        for (int i = 0; i < levelObjects.Length; i++)
        {
            if (UnlockedLvl >= i)
            {
                levelObjects[i].lvlButton.interactable = true;
            }
        }
    }

    public void Onclicklvl(int lvlNum)
    {
        currlvl = lvlNum;
        SceneManager.LoadScene(2);
    }

    public void SwitchToMainMenu() => SceneManager.LoadScene(MainMenuSceneIndex);

    
}
