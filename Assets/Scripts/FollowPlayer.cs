using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform PlayerLoc;
    public Vector3 CAMERAOFFSET;
    
    void Update()
    {
        transform.position = PlayerLoc.position + CAMERAOFFSET;
    }
}
