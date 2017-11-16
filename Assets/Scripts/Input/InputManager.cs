using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * this class handles all the input the game needs.
 * it's basically a wrapper for input. 
 */
public class InputManager : MonoBehaviour
{
    /*
     * This float allows for tighter or looser movement. It's confusing. 
     * You can further edit this in Project Settings -> Input
     */
    [SerializeField]
    private float axisThreshhold = 0.2f;

	/* 
     * functions that return values for the wasd/arrow buttons
     */
	public bool Up(){
        return Input.GetAxis(Strings.Movement.VERTICAL) > axisThreshhold;
    }
	public bool Down()
	{
		return Input.GetAxis(Strings.Movement.VERTICAL) < -axisThreshhold;
	}
	public bool Left()
	{
        return Input.GetAxis(Strings.Movement.HORIZONTAL) < -axisThreshhold;
	}
	public bool Right()
	{
        return Input.GetAxis(Strings.Movement.HORIZONTAL) > axisThreshhold;
	}
    public bool Button1()
    {
        return Input.GetKeyDown(KeyCode.Alpha1);
    }
    public bool Button2()
    {
        return Input.GetKeyDown(KeyCode.Alpha2);
    }
    public bool Button3()
    {
        return Input.GetKeyDown(KeyCode.Alpha3);
    }
    public bool mouseclick()
    {
        return Input.GetKey(KeyCode.Mouse0); ;
    }
    public bool reload()
    {
        return Input.GetKey(KeyCode.R); ;
    }

    /* 
     * functions that return values for the mouse position
     */
    public float GetXRot(){
        return Input.GetAxis(Strings.Movement.MOUSE_X);
    }
    public float GetYRot()
	{
        return -Input.GetAxis(Strings.Movement.MOUSE_Y);
	}
}
