using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public SpawnableObject cargoTruck;
    public SpawnableObject fireTruck;
    public SpawnableObject yellowCar;

    // Update is called once per frame
    void Update ()
    {
        if (cargoTruck.SpawnNewObject(Time.deltaTime))
        {
            Instantiate(cargoTruck.objectToSpawn);
        }

        if (fireTruck.SpawnNewObject(Time.deltaTime))
        {
            Instantiate(fireTruck.objectToSpawn);
        }

        if (yellowCar.SpawnNewObject(Time.deltaTime))
        {
            Instantiate(yellowCar.objectToSpawn);
        }
    }
}
