using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMousePosition : MonoBehaviour
{
     private RectTransform rectTransform;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.SetAsLastSibling(); //Makes the Image your Holding get Rendered last
    }
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition; //Gets mouse pos
        rectTransform.position = mousePosition; //Updates the position of the Image to mouse pos
    }

}
