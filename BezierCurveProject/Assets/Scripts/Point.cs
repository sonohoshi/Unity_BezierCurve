using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    void OnMouseDrag() {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        objectPos.z = transform.position.z;
        transform.position = objectPos;
    }
}
