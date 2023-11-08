using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    [SerializeField] private Player _playerPrefab;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private PlayerConfig _playerConfig;


    public override void InstallBindings()
    {
        BindPlayer();
        BindMovementService();
        BindTickableService();
        BindInitializableService();
    }

    private void BindPlayer()
    {
        Container.Bind<PlayerConfig>().FromInstance(_playerConfig);
        Player player = Container.InstantiatePrefabForComponent<Player>(_playerPrefab, _playerSpawnPoint.position, Quaternion.identity, null);
        Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();
    }
    
    private void BindMovementService()
    {
        Container.BindInterfacesAndSelfTo<MovementHandler>().AsSingle().NonLazy();
    }

    private void BindTickableService()
    {
        Container.BindInterfacesAndSelfTo<HelloWorldTick>().AsSingle().NonLazy();
    }
    private void BindInitializableService()
    {
        Container.BindInterfacesAndSelfTo<ExampleOfIInitializable>().AsSingle().NonLazy();
    }
}
