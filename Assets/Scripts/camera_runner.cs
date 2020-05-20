using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_runner : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        transform.position = new Vector3 (player.position.x + offset.x, offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
