using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverLord : MonoBehaviour {

    public static int attrocitiesCommited = 0;
    public static int world1Soldiers, world2Soldiers, world3Soldiers;
    public static int world1People, world2People, world3People;
    public static int world1Terrorist, world2Terrorist, world3Terrorist;
    public static int world1Unrest, world2Unrest, world3Unrest;
    public Text textAttrocities, world1InfoBox, world2InfoBox, world3InfoBox;

	// Use this for initialization
	void Awake ()
    {
		world1People = Mathf.FloorToInt(Random.Range(1000, 9000000));
        world2People = Mathf.FloorToInt(Random.Range(1000, 9000000));
        world3People = Mathf.FloorToInt(Random.Range(1000, 9000000));
    }
	
	// Update is called once per frame
	void Update ()
    {
        world1InfoBox.text = "Unrest = " + world1Unrest + " , " + "Soldiers = " + world1Soldiers + " , " + "Terrorists = " + world1Terrorist + " , " + "People = " + world1People;
        world2InfoBox.text = "Unrest = " + world2Unrest + " , " + "Soldiers = " + world2Soldiers + " , " + "Terrorists = " + world2Terrorist + " , " + "People = " + world2People;
        world3InfoBox.text = "Unrest = " + world3Unrest + " , " + "Soldiers = " + world3Soldiers + " , " + "Terrorists = " + world3Terrorist + " , " + "People = " + world3People;
    }

    public void increaseAttrocities ()
    {
        StartCoroutine(MurderSpree());
        attrocitiesCommited++;
        textAttrocities.text = "Attrocities Committed = " + attrocitiesCommited.ToString();
    }

    public void world1MakeTerrorist ()
    {
        world1Terrorist++;
        if (world1Terrorist > Random.Range(world2People, world3Soldiers))
            increaseAttrocities();
    }

    public void world2MakeTerrorist()
    {
        world2Terrorist++;
        if (world2Terrorist > Random.Range(world1People, world3Soldiers))
            increaseAttrocities();
    }

    public void world3MakeTerrorist()
    {
        world3Terrorist++;
        if (world3Terrorist > Random.Range(0, world2Soldiers))
            increaseAttrocities();
    }

    IEnumerator MurderSpree ()
    {
        Debug.Log("Running IEnum");
        if (world1Terrorist > 1)
        {
            if (Random.Range(0,100) > 40)
            {
                if (world1Soldiers > 0)
                    world1Soldiers--;
                else
                    world1People--;
            }
        }

        if (world2Terrorist > 1)
        {
            if (Random.Range(0, 100) > 40)
            {
                if (world2Soldiers > 0)
                    world2Soldiers--;
                else
                    world2People--;
            }
        }

        if (world3Terrorist > 1)
        {
            if (Random.Range(0, 100) > 40)
            {
                if (world3Soldiers > 0)
                    world3Soldiers -= world3Terrorist;
                else
                    world3People -= world3Terrorist * Random.Range(1,10);
            }
        }

        yield return new WaitForSecondsRealtime(1f);
        StartCoroutine(MurderSpree());
    }
}
