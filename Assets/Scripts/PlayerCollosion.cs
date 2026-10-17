using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class PlayerCollosion : MonoBehaviour

    
{
    public ForceScriptPlayer StopPlayer;
    public TextMeshProUGUI gameoverTXT;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter (Collision collisionInfo)

    {
        gameoverTXT.gameObject.SetActive(false);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            StopPlayer.enabled = false;
            GOtxt();
            FindAnyObjectByType<GameManager>().EndGame();
        }

        /*if(collisionInfo.collider.tag == "FinishLine")
        {
            StopPlayer.enabled = false;
            WinTXT.gameObject.SetActive(true);

        }*/



    }

    public void GOtxt() 
    { 
        gameoverTXT.gameObject.SetActive(true);
    }
    
}
