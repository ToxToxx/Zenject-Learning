using System;
using UnityEngine;

public interface IInput
{
    public event Action<Vector3> OnClickDown;
    public event Action<Vector3> OnClickUp;
    public event Action<Vector3> OnDrag;
}
