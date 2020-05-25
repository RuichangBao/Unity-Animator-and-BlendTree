using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{

	public Animator animator;
	//上次按的键
	public KeyCode lastKeyCode = 0;
	//上次按键时间
	public long lastKeyCodeTimer = 0;
	//
	public bool isRuning = false;
	enum state
	{
		idle = 0,  //
		run = 1,   //行走状态
		runing = 2,//奔跑状态
		death = 3, //死亡状态
	}

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			GetKeyMove(KeyCode.A);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			GetKeyMove(KeyCode.D);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			GetKeyMove(KeyCode.S);
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			GetKeyMove(KeyCode.W);
		}



		if (Input.GetKey(KeyCode.A))
		{
			if (isRuning)
			{ animator.SetInteger("state", (int)state.runing); }
			else
			{
				animator.SetInteger("state", (int)state.run);
			}
		}
		if (Input.GetKey(KeyCode.D))
		{
			if (isRuning)
			{
				animator.SetInteger("state", (int)state.runing);
			}
			else
			{
				animator.SetInteger("state", (int)state.run);
			}
		}
		if (Input.GetKey(KeyCode.S))
		{
			if (isRuning)
			{ animator.SetInteger("state", (int)state.runing); }
			else
			{
				animator.SetInteger("state", (int)state.run);
			}
		}
		if (Input.GetKey(KeyCode.W))
		{
			if (isRuning)
			{
				animator.SetInteger("state", (int)state.runing);
			}
			else
			{
				animator.SetInteger("state", (int)state.run);
			}
		}

		if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W))
		{
			MoveOver();
		}


		if (Input.GetKeyDown(KeyCode.J))
		{
			Debug.LogError("jjjjjjjjj");
			animator.SetTrigger("attack");
		}
	}

	/// <summary>
	/// 按下移动键
	/// </summary>
	private void GetKeyMove(KeyCode keyCode)
	{
		if (MyTimeUtil.GetCurrTimeMM - lastKeyCodeTimer <= 500&&keyCode==lastKeyCode)//半秒
		{
			isRuning = true;
		}
		else
		{
			isRuning = false;
			this.lastKeyCode = keyCode;
			lastKeyCodeTimer = MyTimeUtil.GetCurrTimeMM;
		}

	}

	private void MoveOver()
	{
		animator.SetInteger("state", (int)state.idle);
		isRuning = false;
	}
}