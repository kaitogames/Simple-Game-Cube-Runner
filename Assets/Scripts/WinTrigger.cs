using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager GManager;
    public void OnTriggerEnter()
    {
        GManager.LevelWin();   
    }

}
