using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 OffSet;

    private void OnMouseDrag()
    {
        Vector3 MousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        Vector3 ObjectPosition = Camera.main.ScreenToWorldPoint(MousePosition);
        transform.position = ObjectPosition + OffSet;
    }
    private void OnMouseDown()
    {
        OffSet = transform.position - Camera.main.ScreenToWorldPoint (Input.mousePosition);
    }
}
