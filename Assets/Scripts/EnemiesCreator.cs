using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemiesCreator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _enemiesParent;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private List<Material> _enemiesMaterials;
    [SerializeField] private Vector3 _goalkeeperStartPoint;
    [SerializeField] private int _minX;
    [SerializeField] private int _maxX;
    [SerializeField] private int _minZ;
    [SerializeField] private int _maxZ;

    private List<Enemy> _enemies = new();
    private bool _isGoalKeeperAlreadyInstantiate;
    private bool _flag;
    // private Player _player;

    private void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            var enemy = CreateEnemy(i);
            _enemies.Add(enemy);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            for (int i = 0; i < _enemies.Count; i++)
            {
                Debug.Log(_enemies[i].Name);
            }
        }
    }

    private Enemy CreateEnemy(int enumerator)
    {
        if (enumerator == 0) // goalkeeper
        {
            var enemy = Instantiate(_enemy, _goalkeeperStartPoint, Quaternion.identity, _enemiesParent);
            enemy.InitializeEnemy
            (GameConstants.ENEMY_GOALKEEPER_HEALTH,
                GameConstants.ENEY_GOALKEEPER_DAMAGE,
                GameConstants.ENEMY_GOALKEEPER_COOLDOWN,
                GameConstants.ENEMY_GOALKEEPER_NAME,
                _player
            );
            enemy.GetComponent<MeshRenderer>().material = _enemiesMaterials[0];
            return enemy;
        }

        if (enumerator % 2 == 1) // striker
        {
            var point = CreateStartEnemyPoint(_enemies[0]);
            var enemy = Instantiate(_enemy, point, Quaternion.identity, _enemiesParent);
            enemy.InitializeEnemy
            (GameConstants.ENEMY_STRIKER_HEALTH,
                GameConstants.ENEMY_STRIKER_DAMAGE,
                GameConstants.ENEMY_STRIKER_COOLDOWN,
                GameConstants.ENEMY_STRIKER_NAME,
                _player
            );
            enemy.GetComponent<MeshRenderer>().material = _enemiesMaterials[1];
            return enemy;
        }

        if (enumerator % 2 == 0) // flyer
        {
            var point = CreateStartEnemyPoint(_enemies[0]);
            var enemy = Instantiate(_enemy, point, Quaternion.identity, _enemiesParent);
            enemy.InitializeEnemy
            (GameConstants.ENEMY_FLYER_HEALTH,
                GameConstants.ENEMY_FLYER_DAMAGE,
                GameConstants.ENEMY_FLYER_COOLDOWN,
                GameConstants.ENEMY_FLYER_NAME,
                _player
            );
            enemy.GetComponent<MeshRenderer>().material = _enemiesMaterials[2];
            return enemy; 
        }

        return null;
    }

    private Vector3 CreateStartEnemyPoint(Enemy enemy)
    {
        float radius = enemy.GetComponent<SphereCollider>().radius;
        int maxAttempt = 25;
        for (int i = 0; i < maxAttempt; i++)
        {
            Vector3 point = new Vector3(Random.Range(_minX, _maxX + 1), radius * 3 + 0.1f,
                Random.Range(_minZ, _maxZ + 1));
            Collider[] colliders = Physics.OverlapSphere(point, radius);
            if (colliders.Length == 0)
            {
                return point;
            }
        }

        return _goalkeeperStartPoint;
    }
}