using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public int hp = 5;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = target.position + new Vector3(0, 0.3f, 0) - transform.position;
        vec.Normalize();
        Quaternion q = Quaternion.LookRotation(vec);
        transform.rotation = q;
        transform.Translate(new Vector3(0,0, 1 * Time.deltaTime));
        transform.GetComponent<Rigidbody>().MovePosition(new Vector3());
        
        if (Vector3.Distance(transform.position, target.position) < 0.25f)
        {
            Destroy(gameObject);
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void onTriggerEnter(Collider col)
    {
        Debug.Log("3");
    }
}
