using UnityEngine;

public class movingobscript : MonoBehaviour
{
    public Rigidbody movingenemy;
    public float force = 200f;

    void Start()
    {
        movingenemy.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "movingblockage 1")
        {
            movingenemy.AddForce(-force * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (collisionInfo.collider.tag == "movingblockage 2")
        {
            movingenemy.AddForce(force * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
