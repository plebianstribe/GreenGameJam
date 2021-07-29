using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public float padding = 0;
    public GameObject animalTemplate;
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
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            spawnAnimal();
        }
    }

    // Spawn Trash
    void spawnAnimal() {
        float randomX = Random.Range(-spawnAreaWidth + padding, spawnAreaWidth - padding);
        float randomY = Random.Range(-spawnAreaHeight + padding, spawnAreaHeight - padding);
        Instantiate(animalTemplate, new Vector3(randomX, randomY, 0), Quaternion.identity, gameObject.transform);
    }
}
