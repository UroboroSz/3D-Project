using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CameraManager : MonoBehaviour
{
    //Variables
    public Transform player;
    public Vector3 offset;
    private float mouseX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, player.position.z + offset.z);
    }
}
