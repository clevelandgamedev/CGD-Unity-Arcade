using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	public float moveSpeed = 10.0f;
	public float jumpSpeed = 10.0f;
	public float gravity = 20.0f;
	private Vector3 moveDirection = Vector3.zero;

	void Start () 
	{
		
	}

	void Update () 
	{
		CharacterController cc = gameObject.GetComponent("CharacterController") as CharacterController;
		if(cc.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"),0,0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= moveSpeed;
			
			if(Input.GetButtonDown("Jump"))
			{
				moveDirection.y = jumpSpeed;	
			}
		}
		moveDirection.y -=gravity * Time.deltaTime;
		cc.Move (moveDirection * Time.deltaTime);
		
	}
}
