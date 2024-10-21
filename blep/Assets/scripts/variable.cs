using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{

    int age = 20;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Starting age is " + age);
        int newAge = nextYear(age);
        Debug.Log("New age is " + newAge);
        newAge = afterYears(newAge, 5);
        Debug.Log("WHAT! Im now " + newAge);

    }

    int nextYear(int currentAge)
    {

        return currentAge += 1;

    }

    int afterYears(int currentAge, int amount)
    {

        return currentAge += amount;

    } 

}
