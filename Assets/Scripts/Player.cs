using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    private MovementHandler _movementHandler;

    [Inject]
    private void Construct(MovementHandler movementHandler)
    {
        Debug.Log(movementHandler.GetType());
        _movementHandler = movementHandler;
    }
}
