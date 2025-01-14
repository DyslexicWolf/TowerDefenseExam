using MapSystem.Model;
using NUnit.Framework;
using StatePattern;
using System.Collections.Generic;

namespace TowerDefense.Model
{
    public class IdleState : IState
    {
        private readonly EnemyModel _enemy;

        public IdleState(EnemyModel enemy)
        {
            _enemy = enemy;
        }

        public void OnEnter()
        {
            _enemy.Idle();
        }

        public void OnExit()
        {
        }

        public void Update(float deltaTime)
        {
            _enemy.Idle();
        }
    }
}

