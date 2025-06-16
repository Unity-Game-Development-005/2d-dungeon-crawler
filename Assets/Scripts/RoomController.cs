
using UnityEngine;



public class RoomController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collidingObject)
    {
        // if the player enters a new room
        if (collidingObject.CompareTag("Player"))
        {
            // move the camera to the new room
            CameraController.cameraControllerScript.EnterNewRoom(transform);
        }
    }


} // end of class
