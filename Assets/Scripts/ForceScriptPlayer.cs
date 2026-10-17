using TMPro;
using UnityEngine;


public class ForceScriptPlayer : MonoBehaviour
{
    public Rigidbody Player;
    public float ForwardF = 2000f;
    public float LeftrightF = 500f;
    public float downlimit = 1.35f;

    private bool MoveRight = false;
    private bool MoveLeft = false;
    public TextMeshProUGUI gameoverTXT2;
    void Update()
    {
        gameoverTXT2.gameObject.SetActive(false);
        // Always move forward
        Player.AddForce(0, 0, ForwardF * Time.deltaTime);

        // Toggle movement when pressing keys
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight = true;
            MoveLeft = false; // stop moving left if switching
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft = true;
            MoveRight = false; // stop moving right if switching
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            MoveRight = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            MoveLeft = false;
        }

        // Apply forces based on bools
        if (MoveRight)
        {
            Player.AddForce(LeftrightF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (MoveLeft)
        {
            Player.AddForce(-LeftrightF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Player.position.y < downlimit)
        {
            gameoverTXT2.gameObject.SetActive(true);
            FindAnyObjectByType <GameManager>().EndGame();
        }
    }
}
