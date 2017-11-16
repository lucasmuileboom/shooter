using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    private Shoot Shoot;
    private InputManager InputManager;
    private float fireSpeed;
    private int dmg;
    private float reloadtime;
    private int magazinessize;

    private void Start ()
    {
        magazinessize = 7;
        fireSpeed = 2;
        dmg = 40;
        reloadtime = 1;
        InputManager = GetComponent<InputManager>();
        Shoot = GetComponent<Shoot>();
    }
    private void Update ()
    {
        if (InputManager.Button1())//handgun
        {
            fireSpeed = 2;
            dmg = 40;
            reloadtime = 1;
            magazinessize = 7;
            Shoot.SetReloadTime();
        }
        if (InputManager.Button2())//light machine gun
        {
            fireSpeed = 0.5f;
            dmg = 10;
            reloadtime = 1.5f;
            magazinessize = 20;
            Shoot.SetReloadTime();
        }
        if (InputManager.Button3())//machine gun
        {
            fireSpeed = 0.25f;
            dmg = 5;
            reloadtime = 2;
            magazinessize = 30;
            Shoot.SetReloadTime();
        }
    }
    public float Getfirespeed()
    {
        return fireSpeed;
    }
    public int Getdmg()
    {
        return dmg;
    }
    public float Getreloadtime()
    {
        return reloadtime;
    }
    public int Getmagazinessize()
    {
        return magazinessize;
    }
}
