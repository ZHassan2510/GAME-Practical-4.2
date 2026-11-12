using UnityEngine;

public class TopDownCamera : MonoBehaviour
{

    public Transform target;
    //the target we will be following

    public Vector3 offset = new Vector3(0f,30f,0f);

    //the distance the camera will be away from the car, 15 meters above it like the game in the vid

    private void LateUpdate()
    {
        //update is used to drive so late update will be used for the camera so 
        //there is no stuttering

        transform.position = target.position + offset;

        //target.pos gets the car in this case, pos and adds the offset to it and
        //updates the cameras new pos to it
    }
}
