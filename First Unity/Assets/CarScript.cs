using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "CARMAN";
        float heroHeight = 1.5f;
        int heroAge = 12;
        string heroSuperPower = "500 HORSEPOWER!";

        string villainName = "CARDESTROYER";
        float villainHeight = 1.3f;
        int villainAge = 10;
        string villainSuperPower = "CAR BOMBS";
        int ageDifference = (heroAge - villainAge);

        print("HERO STATUS: ");
        print("HERO NAME: " + heroName);
        print("HERO HEIGHT: " + heroHeight + 5);
        print("HERO AGE: " + heroAge);
        print("HERO SUPERPOWER: " + heroSuperPower);

        print("VILLAIN STATUS: ");
        print("VILLAIN NAME: " + villainName);
        print("VILLAIN HEIGHT: " + villainHeight);
        print("VILLAIN AGE: " + villainAge);
        villainSuperPower = "None";
        print("VILLAIN SUPERPOWER: " + villainSuperPower);
        print("AGE DIFFERENCE: " + ageDifference);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}