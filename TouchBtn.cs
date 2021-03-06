using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Vehicles.Car;


public class TouchBtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public CarController m_Car;
	private void Awake()
	{
		m_Car = (CarController) GameObject.Find("Car").GetComponent(typeof(CarController));
	}	
	private bool pressed;
	private bool flag;
	void Update()
	{
		if (pressed) {
			m_Car.Move (Input.acceleration.x, 3.0f, 0f, 0f);
		} else if(flag) {
			m_Car.Move (Input.acceleration.x, 0f, -0.5f, 0f);
		}
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		flag = true;
		pressed = true;
	}
	public void OnPointerUp(PointerEventData eventData)
	{
		pressed = false;
	}

}
