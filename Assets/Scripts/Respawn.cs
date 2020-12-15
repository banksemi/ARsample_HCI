using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private float TimeLeft = 0.7f;
    private float nextTime = 0.0f;
    public GameObject prefab;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void CreateObject()
    {
        GameObject item = Instantiate(prefab);
        item.transform.position = transform.position;
        item.transform.Translate(new Vector3(0, 0.5f, 0));
        item.GetComponent<bird_script>().target = target.transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            CreateObject();
        }
    }
}
