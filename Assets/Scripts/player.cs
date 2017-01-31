using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Controller2D))]
public class player : MonoBehaviour {

    public float jumpHeight = 4;
    public float timeToJumpApex = .4f;

    public float moveSpeed = 6;
    public float speedMultiplier, speedIncreaseMilestone;
    private float speedMilestoneCount;
    float gravity;
    Vector3 velocity;

    float jumpVelocity;

    Controller2D controller;

    public Controller2D gameOver;

	void Start () {
        controller = GetComponent<Controller2D>();
        gravity = -(2 * jumpHeight) / (Mathf.Pow(timeToJumpApex, 2));
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        speedMilestoneCount = speedIncreaseMilestone;
	}
	
	void Update () {

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        if ((Input.GetButtonDown("Jump") || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
        }

        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;
            speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier;
            moveSpeed = moveSpeed * speedMultiplier;
        }

        velocity.x = moveSpeed;

        velocity.y += gravity * Time.deltaTime;
        
        controller.Move(velocity * Time.deltaTime);

	}
}
