using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI ScoreTXT;


    void Update()
    {
        ScoreTXT.text = player.position.z.ToString("0");

    }
}
