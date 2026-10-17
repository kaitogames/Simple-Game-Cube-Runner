using UnityEngine;

public class exirscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void exit()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }
   
}
