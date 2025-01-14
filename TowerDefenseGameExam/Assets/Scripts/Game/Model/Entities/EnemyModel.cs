using MapSystem.Model;
using StatePattern;
using System;
using System.Collections.Generic;

namespace TowerDefense.Model
{
    public class EnemyModel : ModelBase//, IDamageable ???
    {
        private ICoordinate _position;

        public bool IsActive { get; set; } = true;

        public int Health;
        public List<CellModel> PathToGoal = new List<CellModel>();
        public StateMachine StateMachine { get; private set; }

        public EventHandler AttackGoal;
        public EventHandler WalkToGoal;
        public EventHandler IdleInPlace;

        public ICoordinate NextPosition
        {
            get => _position;
            set
            {
                if (_position == value) return;

                _position = value;
                OnPropertyChanged();
            }
        }

        public ICoordinate CurrentPosition { get; set; }

        public bool IsAllowedToMove => CurrentPosition == NextPosition;

        public EnemyModel(ICoordinate position, List<CellModel> pathToGoal, int health)
        {            
            NextPosition = position;
            CurrentPosition = position;
            Health = health;
            PathToGoal = pathToGoal;
            StateMachine = new StateMachine(new WalkingState(this, pathToGoal));
        }

        public void SelfDestruct()
        {
            IsActive = false;
            OnDestroySelf();
        }

        public void Attack()
        {
            OnAttackGoal();
        }

        public void Walk()
        {
            OnWalkToGoal();
        }

        public void Idle()
        {
            OnIdleInPlace();
        }

        protected virtual void OnIdleInPlace()
        {
            IdleInPlace?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnWalkToGoal()
        {
            WalkToGoal?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnAttackGoal()
        {
            AttackGoal?.Invoke(this, EventArgs.Empty);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                SelfDestruct();
            }
        }
    }
}
