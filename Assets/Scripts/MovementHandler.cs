using System;
using UnityEngine;

public class MovementHandler : IDisposable
{
    private IInput _input;
    private IMovable _movable;

    public MovementHandler(IInput input, IMovable movable)
    {
        _input = input;
        _movable = movable;

        Debug.Log(input.GetType());
        Debug.Log($"Скорость полученного IMovable: {movable.Speed}");

        _input.OnClickDown += OnClickDown;
        _input.OnClickUp += OnClickUp;
        _input.OnDrag += OnDrag;

    }

    public void Dispose()
    {
        Debug.Log("Произошли отписки");
        _input.OnClickDown -= OnClickDown;
        _input.OnClickUp -= OnClickUp;
        _input.OnDrag -= OnDrag;
    }

    private void OnDrag(Vector3 position)
    {
        Debug.Log("Drag");
    }

    private void OnClickUp(Vector3 position)
    {
        Debug.Log("Click Up");
    }

    private void OnClickDown(Vector3 position)
    {
        Debug.Log("Click Down");
    }
}
