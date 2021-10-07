using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCtrl : MonoBehaviour
{
    private Transform bg1, bg2;
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        bg1 = GameObject.Find("/Background/Background_1").transform;
        bg2 = GameObject.Find("/Background/Background_2").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        bg1.Translate(0, -step, 0);
        bg2.Translate(0, -step, 0);

        if (bg1.position.y <= -10)
            bg1.Translate(0, 20, 0);
        if (bg2.position.y <= -10)
            bg2.Translate(0, 20, 0);
    }
}
