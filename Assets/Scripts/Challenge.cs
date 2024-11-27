using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour
{
    public List<Virtue> virtuesTested; //which types of tokens may be spent on this challenge
    public int difficulty; //how many fail tokens are added to the pool
    [SerializeField] private List<string> pool; //the pool of tokens from which one is drawn at random upon resolution

    public void Setup()
    {

    }

    public void Resolve()
    {
        //pick a random token from the pool
    }
}
