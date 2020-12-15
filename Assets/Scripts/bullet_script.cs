using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour
{
    public Transform target;
    public float speed = 2.5f;
    private bool first = true;
    private Quaternion quaternion;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {

            Vector3 vec = target.position + new Vector3(0, 0.15f, 0) - transform.position;
            vec.Normalize();
            quaternion = Quaternion.LookRotation(vec);
            transform.rotation = quaternion;
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            transform.GetComponent<Rigidbody>().MovePosition(new Vector3());

            if (Vector3.Distance(transform.position, target.position) < 0.2f)
            {
                Destroy(gameObject);
                target.GetComponent<bird_script>().hp -= 1;

                GameObject item = Instantiate(effect);
                item.transform.position = target.position;
                Destroy(item, 2f);

            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
