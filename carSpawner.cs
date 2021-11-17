using UnityEngine;

public class carSpawner : spawnerClass
{


    void Update() {
        Spawner(); 
    
    }

    public void Spawner()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            spawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    public void spawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex]; 

        Instantiate(car1Prefab,spawnPoint.position,spawnPoint.rotation); 


    }

}
