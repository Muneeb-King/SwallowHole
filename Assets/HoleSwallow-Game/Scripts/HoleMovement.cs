using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using System.Linq;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class HoleMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Joystick FixedJoystick;
    [SerializeField] private float MoveSpeed = 3f;
    public Slider slider;
    private float MaxValue=0f;
    public GameObject LossPanel;
    public GameObject WinPanel;
    public Text CollectedTxt;
    public int Collected = 0;
    public GameObject Bridge;
    private Animator anim;
    bool ObjectsCompleted = false;

    void  Start() 
    {
        MaxValue = 0;
       anim = GetComponent<Animator>();
        GameObject[] Destroys = GameObject.FindGameObjectsWithTag("Destroy");
       
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(FixedJoystick.Horizontal * MoveSpeed, rb.velocity.y, FixedJoystick.Vertical * MoveSpeed);
        GameObject[] Destroys = GameObject.FindGameObjectsWithTag("Destroy");
        if (Destroys.Length == 0)
        {
            WinPanel.SetActive(true);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Destroy")//Level-01 Code
        {
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            //other.gameObject.GetComponent<BoxCollider>().enabled = false;
            //other.gameObject.GetComponent<SphereCollider>().enabled = false;    
            Collected++;
            CollectedTxt.text = "Collected :" + Collected;
            ValueChange();
            slider.GetComponent<Slider>().value = MaxValue;

            if (Collected == 19)
            {
                Destroy(Bridge);
              
            }
    } 
    {
        }
        if (other.tag == "Destroy1") //Level-02 Code
        {
            Destroy(other.gameObject);
            Collected++;
            CollectedTxt.text = "Collected :" + Collected;
            ValueChange();
            slider.GetComponent<Slider>().value = MaxValue;
     
           if (Collected == 50)
            {
                WinPanel.SetActive(true);
            }
        }
        if (other.tag == "Destroy2") //Level-03 Code
        {
            Destroy(other.gameObject);
            //collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
            //collision.gameObject.GetComponent<BoxCollider>().enabled = false;
            Collected++;
            CollectedTxt.text = "Collected :" + Collected;
            ValueChange();
            slider.GetComponent<Slider>().value = MaxValue;
            if (Collected == 80)
            {
                WinPanel.SetActive(true);
            }
        }
        if (other.tag == "Enemy")
        {
            LossPanel.SetActive(true);
        }
    }
    public void ValueChange() 
    {
        MaxValue++;
    }
  
}
