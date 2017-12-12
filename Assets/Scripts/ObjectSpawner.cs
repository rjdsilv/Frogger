using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public SpawnableObject cargoTruck;
    public SpawnableObject fireTruck;
    public SpawnableObject yellowCar;
    public SpawnableObject turtle;
    public SpawnableObject mediumLog;
    public SpawnableObject bigLog;

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

        if (mediumLog.SpawnNewObject(Time.deltaTime))
        {
            Instantiate(mediumLog.objectToSpawn);
        }

        if (bigLog.SpawnNewObject(Time.deltaTime))
        {
            Instantiate(bigLog.objectToSpawn);
        }

        if (turtle.SpawnNewObject(Time.deltaTime))
        {
            GameObject first = Instantiate(turtle.objectToSpawn);
            GameObject second = Instantiate(turtle.objectToSpawn);
            GameObject third = Instantiate(turtle.objectToSpawn);

            second.transform.position = first.transform.position + new Vector3(1.05f, 0, 0);
            third.transform.position = second.transform.position + new Vector3(1.05f, 0, 0);
        }
    }
}
