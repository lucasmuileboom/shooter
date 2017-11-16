using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornade_Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float zSpeed;
    [SerializeField]
    private float distance;
    [SerializeField]
    private float zDistance;
    private float rotation;
    private float zOffset;

    // Use this for initialization
    void Start()
    {
        rotation = Random.Range(0.0f, 2.0f * Mathf.PI);
        zOffset = Random.Range(0.0f, 2.0f * Mathf.PI);
    }
	
	// Update is called once per frame
	void Update()
    {
        rotation += speed / 100;
        rotation %= 2 * Mathf.PI;
        this.transform.position = new Vector3(Mathf.Sin(rotation) * distance, Mathf.Sin(rotation * zSpeed + zOffset) * zDistance, Mathf.Cos(rotation) * distance);
        this.transform.LookAt(Vector3.zero);
        this.transform.Rotate(new Vector3(0,-90,0));
	}
}
