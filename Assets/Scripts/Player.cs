using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour, IMovable
{
    public float Speed => 5f;
    public Transform Transform => transform;



    /*
    private MovementHandler _movementHandler;

    [Inject]
    private void Construct(MovementHandler movementHandler)
    {
        Debug.Log(movementHandler.GetType());
        _movementHandler = movementHandler;
    }*/
}
