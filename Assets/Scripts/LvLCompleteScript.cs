using UnityEngine;
using UnityEngine.SceneManagement;

public class LvLCompleteScript : MonoBehaviour
{
    public void OnLVLcomplete()
    {
        if (LvlSelectionManager.currlvl == LvlSelectionManager.UnlockedLvl)
        {
            LvlSelectionManager.UnlockedLvl++;
            PlayerPrefs.SetInt("UnlockedLvl", LvlSelectionManager.UnlockedLvl);
        }
        SceneManager.LoadScene(0);
    }
}
