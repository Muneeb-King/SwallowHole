using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NotchHandler : MonoBehaviour
{
    RectTransform rectTransform;
    Rect SafeArea;
    Vector2 MinAnchor;
    Vector2 MaxAnchor;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        SafeArea = Screen.safeArea;
        MinAnchor = SafeArea.position;
        MaxAnchor = MinAnchor + SafeArea.size;
        
        MinAnchor.x /= Screen.width;
        MaxAnchor.x /= Screen.width;
        MinAnchor.y /= Screen.height;
        MaxAnchor.y /= Screen.height;

        rectTransform.anchorMax = MaxAnchor;
        rectTransform.anchorMin = MinAnchor;
    }
    
}
