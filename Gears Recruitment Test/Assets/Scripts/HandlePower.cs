using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePower : MonoBehaviour
{
    PoweredGear poweredGear;

    private void Start()
    {
        poweredGear = GetComponentInParent<PoweredGear>();
    }

    private void Update()
    {
        //If mouse button is pressed down, check if power gear with handle needs to be rotated
        if (Input.GetMouseButton(0))
            CheckForMoveByHandle();

    }

    private void CheckForMoveByHandle()
    {
        //Get mouse position in world position
        Vector3 MouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Get distance between mouse position and handle position ignoring position.z
        MouseWorldPosition.z = transform.position.z;
        float distance = Vector3.Distance(MouseWorldPosition, transform.position);

        //Get dot value from vector runing from handle to mouse positon and vector to the right of handle transform
        //If dot is positive - mouse is on the relative right of handle, if negative - left side of handle
        float dot = Vector2.Dot(MouseWorldPosition - transform.position, transform.right);

        //If distance between handle and mouse is too small or too big - dont rotate gear
        if (distance < .01f || distance > 1.5f)
            return;

        //Rotate power gear clockwise or anti-clockwise using dot value
        //distance determines what % of default gear speed is used, and in what direction
        if (dot > .01f)
            poweredGear.RotateControl(distance);
        else if (dot < -.01f)
            poweredGear.RotateControl(-distance);
        
    }
}
