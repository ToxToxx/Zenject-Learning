using UnityEngine;
using Zenject;

public class HelloWorldTick : ITickable
{
    private float messageTimer = 0f;
    private float messageTimerMax = 10f;
    public void Tick()
    {
        SayTick();
    }

    private void SayTick()
    {
        if(messageTimer < messageTimerMax)
        {           
            messageTimer += Time.deltaTime;
        }
        else
        {
            messageTimer = 0f;
            Debug.Log("Tick");
        }
    }
}
