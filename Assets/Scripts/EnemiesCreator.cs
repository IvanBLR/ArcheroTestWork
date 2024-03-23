using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemiesCreator : MonoBehaviour
{
    [SerializeField] private Transform _enemiesParent;
    [SerializeField] private List<Enemy> _enemy;

    [SerializeField] private Vector3 _goalkeeperStartPoint;
    [SerializeField] private int _minX;
    [SerializeField] private int _maxX;
    [SerializeField] private int _minZ;
    [SerializeField] private int _maxZ;

    private bool _isGoalKeeperAlreadyInstantiate;
    private bool _flag;
   // private Vector3 _startEnemyPoint;

    private void Start()
    {
        //_startEnemyPoint = Vector3.zero;
        for (int i = 0; i < _enemy.Count; i++)
        {
            Debug.Log($"it is {i} Instantiate iteration");
            CreateEnemy(_enemy[i]);
        }
    }

    private void CreateEnemy(Enemy enemy)
    {
        if (enemy is EnemyGoalkeeper)
        {
            if (_isGoalKeeperAlreadyInstantiate)
            {
                Debug.Log("Goalkeeper is already exist");
                return;
            }

            Instantiate(enemy, _goalkeeperStartPoint, Quaternion.identity, _enemiesParent);
            _isGoalKeeperAlreadyInstantiate = true;
        }
        else
        {
           var point = CreateStartEnemyPoint(enemy);
            Instantiate(enemy, point, Quaternion.identity, _enemiesParent);
        }
    }

    private Vector3 CreateStartEnemyPoint(Enemy enemy)
    {
        float radius = enemy.GetComponent<SphereCollider>().radius;
        int maxAttempt = 25;
        for (int i = 0; i < maxAttempt; i++)
        {
            Vector3 point = new Vector3(Random.Range(_minX, _maxX + 1), radius * 3 + 0.1f, Random.Range(_minZ, _maxZ + 1));
            Collider[] colliders = Physics.OverlapSphere(point, radius);
            if (colliders.Length == 0)
            {
                Debug.Log($"success before {i} attempt");
                return point;
            } 
        }

        return _goalkeeperStartPoint;

    }
}