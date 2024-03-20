using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform player;
    // Update is called once per frame
    private void Update()
    {
        // Set the camera's position to the player's position
        transform.position = new Vector3(player.position.x, player.position.y+2f, transform.position.z);
    }
}
