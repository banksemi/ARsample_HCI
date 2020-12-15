using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    private float TimeLeft = 0.2f;
    private float nextTime = 0.0f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CreateObject(GameObject obj)
    {
        GameObject item = Instantiate(bullet);
        item.transform.position = transform.position;
        item.transform.Translate(new Vector3(0, 0.25f, 0));
        item.GetComponent<bullet_script>().target = obj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            List<GameObject> FoundObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Respawn"));
            if (FoundObjects.Count > 0)
                CreateObject(FoundObjects[0]);
        }
    }

    void onTriggerEnter(Collider col)
    {
        Debug.Log("2");
    }
}
