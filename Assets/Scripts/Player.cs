using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour, IMovable
{
    public float Speed { get; private set; }
    public Transform Transform => transform;


    [Inject]
    private void Construct(PlayerConfig playerConfig)
        => Speed = playerConfig.Speed;
}
