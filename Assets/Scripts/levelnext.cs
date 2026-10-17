using UnityEngine;
using UnityEngine.SceneManagement;

public class levelnext : MonoBehaviour
{
    public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
