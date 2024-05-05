using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public void OnlvlComplete(int starAquired)
    {
        if (LevelSelectionManager.currlvl == LevelSelectionManager.Unlockedlvl)
        {
            LevelSelectionManager.Unlockedlvl++;
            PlayerPrefs.SetInt("Unlockedlvl", LevelSelectionManager.Unlockedlvl);
        }
        if (starAquired > PlayerPrefs.GetInt("stars" + LevelSelectionManager.currlvl.ToString(), 0))
        {
            PlayerPrefs.SetInt("stars" + LevelSelectionManager.currlvl.ToString(), starAquired);
        }
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
