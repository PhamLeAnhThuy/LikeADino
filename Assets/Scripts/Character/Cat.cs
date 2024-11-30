using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Character
{
    [SerializeField] private int catLife = 5;

    public Cat()
    {
        this.life = catLife;
    }

}
