using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCreater : MonoBehaviour
{
    public GameObject MonsterPrefab;
    public Sprite[] images;
    private float[] scales;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateMonster", 0.1f, 0.5f);
        scales = new float[images.Length];
        for (int i = 0; i < images.Length; i++)
            scales[i] = 100 / images[i].rect.width;


    }

    // Update is called once per frame
    void Update()
    {

        
    }
    
    private void CreateMonster()
    {
        Vector3 monsterWorldPos = new Vector3(Random.Range(-2, 2) , 5, 0);
        int imageIdx = Random.Range(0, images.Length);
        // Debug.Log("Monster" + monsterWorldPos);
        GameObject monster = Instantiate(MonsterPrefab);
        monster.transform.position = monsterWorldPos;

        SpriteRenderer renderer = monster.GetComponent<SpriteRenderer>();
        renderer.sprite = images[imageIdx];
        monster.transform.localScale = new Vector3(scales[imageIdx], scales[imageIdx], scales[imageIdx]);
    }
}
