using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phpscript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DoPHP(gameObject.transform));
    }
    private IEnumerator DoPHP(Transform position)//player_id && gun
    {
         WWW request = new WWW("http://20126.hosts.ma-cloud.nl/bewijzenmap/p1.4/data/database.php?pos=["+ position.position.x+","+ position.position.y+ ","+ position.position.z+ "]&?playerID=0");
         yield return request;
         print(request);
    }
}
