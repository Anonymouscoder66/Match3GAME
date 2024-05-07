using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] lvls;

    void Start()
    {
        lvls[LvlSelectionManager.currlvl].SetActive(true);
    }
}
