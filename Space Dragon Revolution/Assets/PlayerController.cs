using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

	private void Start()
	{
		animator = GetComponent<Animator>();
	}

	private void Update()
	{
		if (Input.GetButtonDown("Fire1")){
			animator.SetBool("attack1", true);
		}

		if (Input.GetButtonDown("Fire2"))
		{
			animator.SetBool("flyGlide", true);
		}
	}
}
