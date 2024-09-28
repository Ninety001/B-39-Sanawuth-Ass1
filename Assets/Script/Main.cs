using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IronMan ironMan = new IronMan("Tony", 100, "Red");
        CaptainAmerica captainAmerica = new CaptainAmerica("Steve", 120, "Blue");

        // Ironman info
        Debug.Log($"IronMan name: {ironMan.Name}, hp: {ironMan.HP}, color: {ironMan.SuitColor}");

        // Captain america info
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, hp: {captainAmerica.HP}, color: {captainAmerica.SuitColor}");

        // Fight for 5 turn
        for (int turn = 1; turn <= 5; turn++)
        {
            Debug.Log($"--- Turn {turn} ---");

            // IronMan Attack Captain America
            ironMan.ShootLaser();
            captainAmerica.TakeDamage();

            // check Captain America is dead?
            if (captainAmerica.IsDead())
            {
                Debug.Log("Captain America is dead. Iron Man wins!");
                break;
            }

            // Captain America attack IronMan
            captainAmerica.ThrowShield();
            ironMan.TakeDamage();

            // check Iron Man is dead?
            if (ironMan.IsDead())
            {
                Debug.Log("Iron Man is dead. Captain America wins!");
                break;
            }

            // check 5 round completed
            if (turn == 5)
            {
                Debug.Log("The fight is over after 5 turns with no clear winner!");
            }
        }
    }
}
