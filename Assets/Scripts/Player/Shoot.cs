using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Text guntxt;
    private InputManager InputManager;
    private Guns Guns;
    private Ray ray;
    private RaycastHit hit;
    private float timer;
    private int range = 100;
    private int bullets = 7;
    private bool reloading = false;

    private void Start ()
    {
        InputManager = GetComponent<InputManager>();
        Guns = GetComponent<Guns>();
        guntxt.text = bullets.ToString();
    }
    private void Update ()
    {
        timer -= Time.deltaTime;
        if (!reloading && (InputManager.reload() || bullets <= 0))
        {
            SetReloadTime();
        }
        if (InputManager.mouseclick() && timer < 0 && bullets > 0 && !reloading)
        {
            bullets--;
            guntxt.text = bullets.ToString();
            timer = Guns.Getfirespeed();
            Debug.DrawRay(transform.position, Camera.main.transform.forward * range);
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(transform.position, Camera.main.transform.forward, out hit, range))
            {             
                if (hit.collider.gameObject.tag == "enemy")
                {
                    hit.collider.gameObject.GetComponent<Enemy_Health>().TakeDamage(Guns.Getdmg());
                }
            }
        }
        else if (reloading && timer < 0)
        {
            Reload(); 
        }
    }
    public void SetReloadTime()
    {
        reloading = true;
        guntxt.text = "R";
        timer = Guns.Getreloadtime();
    }
    void Reload()
    {
        bullets = Guns.Getmagazinessize();
        guntxt.text = bullets.ToString();
        reloading = false;
    }
}

