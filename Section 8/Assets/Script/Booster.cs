using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public void HealthBoost(Character target)
    {
        target.hp += 10;
    }

    public void ShieldBoost(Character target)
    {
        target.defense += 10;
    }

    public void DmgBoost(Character target)
    {
        target.dmg += 10;
    }

    private void Awake()
    {
        Character player = FindObjectOfType<Character>();

        player.playerBoost += HealthBoost;
        player.playerBoost += ShieldBoost;
        player.playerBoost += DmgBoost;
    }
}
