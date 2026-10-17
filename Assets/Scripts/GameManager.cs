using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public TextMeshProUGUI WinTXT2;
    public GameObject completelevelui;

    public void LevelWin()
    {
        //WinTXT2.gameObject.SetActive(true);
        completelevelui.SetActive(true);
    }


    bool GameEnded = false;
    public float timedelay = 2f;
    public void EndGame()
    {   if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", timedelay);
        }   
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
