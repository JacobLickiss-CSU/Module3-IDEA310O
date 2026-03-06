using UnityEngine;

public class Collectable : MonoBehaviour
{
    float startHeight = 0f;

    float magic = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startHeight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 45, 0);

        magic += Time.deltaTime;
        transform.position = new Vector3(transform.position.x, startHeight + (Mathf.Sin(magic) * .3f), transform.position.z); ;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().Collect();
            Destroy(gameObject);
        }
    }
}
