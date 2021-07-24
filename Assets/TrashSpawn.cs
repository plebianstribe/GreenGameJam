using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour
{
    public float padding = 0;
    public GameObject trashTemplate;
    public GameObject spawnArea;
    
    float spawnAreaWidth, spawnAreaHeight;

    // Start is called before the first frame update
    void Start()
    {
        spawnAreaWidth = spawnArea.GetComponent<SpriteRenderer>().size.x * spawnArea.transform.localScale.x * 0.5f;
        spawnAreaHeight = spawnArea.GetComponent<SpriteRenderer>().size.y * spawnArea.transform.localScale.y * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnTrash();
        }
    }

    // Spawn Trash
    void SpawnTrash()
    {
        float randomX = Random.Range(-spawnAreaWidth + padding, spawnAreaWidth - padding);
        float randomY = Random.Range(-spawnAreaHeight + padding, spawnAreaHeight - padding);
        Instantiate(trashTemplate, new Vector3(randomX, randomY, 0), Quaternion.identity, gameObject.transform);
    }
}
