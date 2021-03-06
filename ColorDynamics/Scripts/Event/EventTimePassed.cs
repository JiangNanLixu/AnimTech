﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTimePassed : MonoBehaviour {

	public float _LeftTime = 0.5f;
	public UnityEvent _Happen;

	public bool _DisableOnInvoke = true;

	// Update is called once per frame
	void Update () {
		_LeftTime -= Time.deltaTime;
		if (_LeftTime <= 0.0f) {
			if (_DisableOnInvoke) {
				enabled = false;
			}
			_Happen.Invoke ();
		}
	}

	public void SetLeftTime(float leftTime)
	{
		if (leftTime <= 0.0f) {
			enabled = false;
			_LeftTime = 0.0f;
		} else {
			enabled = true;
			_LeftTime = leftTime;
		}

	}

	public void SetLeftTimeEnable(float leftTime)
	{
		SetLeftTime (leftTime);
		enabled = true;
	}
}
