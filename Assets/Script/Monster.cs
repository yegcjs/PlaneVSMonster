using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.WorldToScreenPoint(transform.position).y < 0)
            Destroy(gameObject);
        else
        {
            float step = speed * Time.deltaTime;
            transform.Translate(0, -step, 0, Space.Self);
        }
    }
}
