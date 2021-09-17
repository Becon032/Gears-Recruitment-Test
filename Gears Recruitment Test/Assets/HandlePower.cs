using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePower : MonoBehaviour
{
    PowerGear powerGear;

    private void Start()
    {
        powerGear = GetComponentInParent<PowerGear>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
            CheckForMoveByHandle();
        else if (Input.GetMouseButtonUp(0))
            powerGear.speed = 0;
        
    }

    private void CheckForMoveByHandle()
    {
        Vector3 MouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MouseWorldPosition.z = transform.position.z;
        float distance = Vector3.Distance(MouseWorldPosition, transform.position);

        float dot = Vector2.Dot(MouseWorldPosition - transform.position, transform.right);

        if (distance < .01f)
            return;

        Debug.Log(distance);

        if (dot > .1f)
            powerGear.speed = distance * 250;
        else if (dot < -.1f)
            powerGear.speed = distance * -250;
        else
            powerGear.speed = 0;
        
    }
}
