using JetBrains.Annotations;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -11);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offsett the player by adding the Players Postion
        transform.position = player.transform.position + offset;
    }
}
