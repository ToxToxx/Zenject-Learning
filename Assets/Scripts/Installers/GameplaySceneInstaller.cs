using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
       
        Container.Bind<MovementHandler>().FromNew().AsSingle().NonLazy();
    }

    
}
