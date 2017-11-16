using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database : MonoBehaviour {

	// Use this for initialization
	void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update()
    {

    }

    public void SaveToDataBase(Transform start, Transform end)
    {
        StartCoroutine(DoPHP(start, end));
    }
    public void SaveToDataBase(Vector3 start, Vector3 end)
    {
        StartCoroutine(DoPHP(start, end));
    }
    public void SaveToDataBase(GameObject start, GameObject end)
    {
        StartCoroutine(DoPHP(start, end));
    }

    private IEnumerator DoPHP(Transform start, Transform end)//Transform version
    {
        WWW request = new WWW("http://21886.hosts.ma-cloud.nl/php/supamanvususbamaan.php?startX=" + start.position.x.ToString() + "&startY=" + start.position.y.ToString() + "&startZ=" + start.position.z.ToString() + "&endX=" + end.position.x.ToString() + "&endY=" + end.position.y.ToString() + "&endZ=" + end.position.z.ToString());
        yield return request;
        print(request.text);
    }
    private IEnumerator DoPHP(Vector3 start, Vector3 end)//Vector3 version
    {
        WWW request = new WWW("http://21886.hosts.ma-cloud.nl/php/supamanvususbamaan.php?startX=" + start.x.ToString() + "&startY=" + start.y.ToString() + "&startZ=" + start.z.ToString() + "&endX=" + end.x.ToString() + "&endY=" + end.y.ToString() + "&endZ=" + end.z.ToString());
        yield return request;
        print(request.text);
    }
    private IEnumerator DoPHP(GameObject start, GameObject end)//GameObject version
    {
        WWW request = new WWW("http://21886.hosts.ma-cloud.nl/php/supamanvususbamaan.php?startX=" + start.transform.position.x.ToString() + "&startY=" + start.transform.position.y.ToString() + "&startZ=" + start.transform.position.z.ToString() + "&endX=" + end.transform.position.x.ToString() + "&endY=" + end.transform.position.y.ToString() + "&endZ=" + end.transform.position.z.ToString());
        yield return request;
        print(request.text);
    }
}