using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Chicken", menuName = "ChickenBehaviour")]
public class ChickenBehaviourSO : ScriptableObject
{

    [SerializeField]
    bool isEvil;

    [SerializeField]
    int speed;

    public bool IsEvil() 
    {
        return isEvil;
    }
    public int Speed() 
    {
        return speed;
    }


}
