using System;
using UnityEngine;

public class MovementHandler : IDisposable
{
    private IInput _input;

    public MovementHandler(IInput input)
    {
        _input = input;

        _input.OnClickDown += OnClickDown;
        _input.OnClickUp += OnClickUp;
        _input.OnDrag += OnDrag;

    }

    public void Dispose()
    {
        _input.OnClickDown -= OnClickDown;
        _input.OnClickUp -= OnClickUp;
        _input.OnDrag -= OnDrag;
    }

    private void OnDrag(Vector3 position)
    {
       //код для перетаскивания
    }

    private void OnClickUp(Vector3 position)
    {
        //код при поднятии кнопки
    }

    private void OnClickDown(Vector3 position)
    {
        //код для нажатия
    }
}
