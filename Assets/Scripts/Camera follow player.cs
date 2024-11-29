using UnityEngine;

public class Camerafollowplayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        //make the position of the camera the same as the player gameobject that is in the variable
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
