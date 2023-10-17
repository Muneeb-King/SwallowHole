using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class HoleMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Joystick FixedJoystick;
    [SerializeField] private float MoveSpeed = 6f;
    public Slider slider;
    private float MaxValue=0f;   
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(FixedJoystick.Horizontal * MoveSpeed, rb.velocity.y, FixedJoystick.Vertical * MoveSpeed);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Destroy")
        {
            Destroy(collision.gameObject);
            ValueChange();
            slider.GetComponent<Slider>().value = MaxValue;
        }
    }
    public void ValueChange() 
    {
        MaxValue++;
    }
}
