using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour
{
	public Animator animator;
	public float horizontal;
	public float vertical;
	// Use this for initialization
	void Start()
	{
		this.animator = this.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		horizontal = Input.GetAxis("Horizontal");
		vertical = Input.GetAxis("Vertical");
		animator.SetFloat("dir", horizontal, 0.1f, Time.deltaTime);

		animator.SetFloat("speed", vertical, 0.1f, Time.deltaTime);
	}
}
