/*
 * (Colin Gamagami)
 * (ConcsoleOutput.cs)
 * (Assignment 1)
 * (tests the different classes)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    private List<IExplodeable> explodeables = new List<IExplodeable>();

    // Start is called before the first frame update
    void Start()
    {
        Plane plane = new Plane();
        Car car = new Car();
        Motorcycle motorcycle = new Motorcycle();

        plane.StartUp();
        plane.Explode();
        plane.Repair();

        car.StartUp();
        car.Explode();
        car.Repair();

        vehicles.Add(plane);
        vehicles.Add(car);
        vehicles.Add(motorcycle);
        explodeables.Add(plane);
        explodeables.Add(car);
        explodeables.Add(motorcycle);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.StartUp();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (IExplodeable explodeable in explodeables)
            {
                explodeable.Explode();
            }
        }
    }
}
