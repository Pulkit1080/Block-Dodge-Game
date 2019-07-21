using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public float Score = 0f;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    public GameObject blockPrefab;
    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;
    void SpawnBlocks()
    {
        Debug.Log(Score);
        Score++;

        int randomIndex = Random.Range(0,spawnPoints.Length);
        for (int i=0;i<spawnPoints.Length;i++)
        {
            if(randomIndex!=i)
            {
                Instantiate(blockPrefab,spawnPoints[i].position,Quaternion.identity);
            }
        }

    }

    void Update()
    {
        if(Time.time>=timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }        
    }


}


