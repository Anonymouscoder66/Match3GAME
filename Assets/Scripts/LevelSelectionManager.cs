using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionManager : MonoBehaviour
{
    
    public LevelObject[] LevelObject;
    public static int currlvl;
    public static int Unlockedlvl;

    public Sprite goldenstars;
    public void OnClickLvl(int lvlnum)
    {
        currlvl = lvlnum;
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
    void Start()
    {
        Unlockedlvl = PlayerPrefs.GetInt("Unlockedlvl", 0);
        for (int i = 0; i < LevelObject.Length; i++)
        {
            if(Unlockedlvl >= i)
            {
                LevelObject[i].lvlButton.interactable = true;
                int stars = PlayerPrefs.GetInt("stars"+i.ToString(), 0);
                for (int j = 0; j < stars; j++)
                {
                    LevelObject[i].stars[j].sprite = goldenstars;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
