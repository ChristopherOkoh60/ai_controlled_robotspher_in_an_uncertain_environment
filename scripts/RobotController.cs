using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RobotController : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 4;
    [SerializeField] float rollSpeed = 8;
    private bool ballMode = false;
    private PlayerInputManager input;
    private CharacterController controller;
    private Animator animator;

    [SerializeField] GameObject mainCam;
    [SerializeField] Transform cameraFollowTarget;
    float xRotation;
    float yRotation;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = GetComponent<PlayerInputManager>();
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       SwitchMode();
       if(ballMode)
       MoveBall();
       else
       MoveNormal();
    
    }

    private void LateUpdate()
    {
        CameraRotation();
    }

    void CameraRotation()
    {
        xRotation += input.look.y;
        yRotation += input.look.x;
        xRotation = Mathf.Clamp(xRotation, -15, 70);

        Quaternion rotation = Quaternion.Euler(xRotation, yRotation, 0);
        cameraFollowTarget.rotation = rotation;
    }

    void MoveNormal()
    {
        float speed = 0;
        Vector3 inputDir = new Vector3(input.move.x, 0, input.move.y);
        float targetRotation = 0;
        
        if(input.move != Vector2.zero)
        {
            speed = moveSpeed; 
            targetRotation = Quaternion.LookRotation(inputDir).eulerAngles.y + mainCam.transform.rotation.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0, targetRotation, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 20 * Time.deltaTime);
        }
        animator.SetFloat("speed", input.move.magnitude);
        Vector3 targetDirection = Quaternion.Euler(0, targetRotation, 0) * Vector3.forward;
        controller.Move(targetDirection * speed * Time.deltaTime);
    }

    void MoveBall()
    {
        float speed = 0;
        Vector3 inputDir = new Vector3(input.move.x, 0, input.move.y);
        float targetRotation = 0;
        
        if(input.move != Vector2.zero)
        {
            speed = rollSpeed; 
            targetRotation = Quaternion.LookRotation(inputDir).eulerAngles.y + mainCam.transform.rotation.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0, targetRotation, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 20 * Time.deltaTime);
        }
        animator.SetFloat("rollSpeed", input.move.magnitude);
        Vector3 targetDirection = Quaternion.Euler(0, targetRotation, 0) * Vector3.forward;
        controller.Move(targetDirection * speed * Time.deltaTime);
    }

    void SwitchMode()
    {
         if (input.switchMode)
        {
            ballMode = !ballMode;
            input.switchMode = false;
            animator.SetBool("ballMode", ballMode);
        }
    }
}


