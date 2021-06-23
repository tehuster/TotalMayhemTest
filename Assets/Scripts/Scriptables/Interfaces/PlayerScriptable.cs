using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerScriptable", menuName = "Scriptables/PlayerScriptable", order = 0)]
public class PlayerScriptable : ScriptableObject
{
    // public string playerName;
    public Vector3 currentPosition;
    public int HealthPoints;
    // public float boostPower;
    // public float dodgePower;
}