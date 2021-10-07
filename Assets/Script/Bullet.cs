using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.Translate(0, step, 0, Space.Self);

        Vector3 posScreen = Camera.main.WorldToScreenPoint(transform.position);
        if(posScreen.y > Screen.height)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Monster"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
