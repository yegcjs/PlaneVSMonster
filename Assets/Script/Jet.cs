using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float movingSpeed;

    private float shootingInterval = 0.2f;
    private float deltaTimeCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTimeCount += Time.deltaTime;
        if(deltaTimeCount > shootingInterval)
        {
            deltaTimeCount -= shootingInterval;
            Fire();
        }

        float step = movingSpeed * Time.deltaTime;
        Vector3 newPosition;

        if (Input.GetKey(KeyCode.LeftArrow))
            newPosition = new Vector3(transform.position.x - step, transform.position.y, 0);
        else if (Input.GetKey(KeyCode.RightArrow))
            newPosition = new Vector3(transform.position.x + step, transform.position.y, 0);
        else return;

        Vector3 newScreenPos = Camera.main.WorldToScreenPoint(newPosition);
        if (newScreenPos.x < 0 || newScreenPos.x > Screen.width) return;
        else transform.position = newPosition;
    }

    void Fire()
    {
        Vector3 bulletInitPos = transform.position + Vector3.up;
        GameObject bullet = Instantiate(bulletPrefab, bulletInitPos, transform.rotation);
    }
}
