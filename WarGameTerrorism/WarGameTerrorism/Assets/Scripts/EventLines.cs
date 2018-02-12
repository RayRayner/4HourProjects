using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLines : MonoBehaviour {

    float timeToEvent = 10;
    public static float timer;

    private void Update ()
    {
        
        timer += Time.deltaTime;
        
        if (timer >= timeToEvent)
        {
            timer = 0;
            timeToEvent = Random.Range(30, 120);
            OverLord.world1Soldiers += Mathf.FloorToInt(Random.Range(0, OverLord.world1People/200));
            OverLord.world1People -= OverLord.world1Soldiers;
            OverLord.world2Soldiers += Mathf.FloorToInt(Random.Range(0, OverLord.world2People / 200));
            OverLord.world2People -= OverLord.world2Soldiers;
            OverLord.world3Soldiers += Mathf.FloorToInt(Random.Range(0, OverLord.world3People / 200));
            OverLord.world3People -= OverLord.world3Soldiers;
            Debug.Log("Timer Active");
        }

    }
}
