using System;
using UnityEngine;

public class MobileInput : IInput
{
    public event Action<Vector3> OnClickDown;
    public event Action<Vector3> OnClickUp;
    public event Action<Vector3> OnDrag;
}
