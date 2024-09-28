using System;
using UnityEngine;

public class IronMan
{
    // Properties
    public string Name { get; private set; }
    public int HP { get; private set; }
    public string SuitColor { get; private set; }
    public float ArmorStrength { get; private set; }

    // Constructor
    public IronMan(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        HP = newHp;
        SuitColor = newSuitColor;
        ArmorStrength = 10f;
    }

    // Methods
    public void Fly()
    {
        Debug.Log($"----------- {Name} is Flying");
    }

    public void ShootLaser()
    {
        Debug.Log($"----------- {Name} is Shooting Laser");
    }

    public void UpdateArmorStrength(float strength)
    {
        ArmorStrength += strength;
        Debug.Log($"{Name} updated their armor to {ArmorStrength}");
    }

    public bool IsDead()
    {
        return HP <= 0;
    }

    public void TakeDamage()
    {
        // Damage 10 - 20
        int damage = UnityEngine.Random.Range(10, 21); // Make max random number be 20
        HP -= damage;
        Debug.Log($"{Name} took {damage} damage. Remaining HP: {HP}");

        if (IsDead())
        {
            Debug.Log($"{Name} is dead.");
        }
    }
}
