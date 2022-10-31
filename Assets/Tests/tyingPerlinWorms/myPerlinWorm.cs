using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPerlinWorm : MonoBehaviour
{
    public float speed;
    public float turnyness;
    public float heading;
    public GameObject prefab;
    float placementTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake() {
        // defaults
		if (speed == 0)
		{
			speed = Random.Range( 2.0f, 5.0f);
			heading = Random.Range( 0.0f, 360.0f);
			turnyness = Random.Range( 1450.0f, 2600.0f);
		}
    }

    // Update is called once per frame
    void Update()
    {
        placementTimer += 0.1f;
        Vector3 position = transform.position;
        float x = position.x;
        float y = position.y;
        float noise = Mathf.PerlinNoise(x, y);
        noise -= 0.5f;
        float turn = noise * turnyness;
        Vector3 direction = Quaternion.Euler (0, 0, heading) * Vector3.up;
        heading += turn * Time.deltaTime;
        position += direction * (speed * Time.deltaTime);
        transform.position = position;

        if (placementTimer >= 3f)
        {
            Instantiate(prefab, new Vector3(Mathf.Round(position.x), Mathf.Round(position.y), Mathf.Round(position.z)), Quaternion.identity);
            placementTimer = 0f;
        }
    }
}
