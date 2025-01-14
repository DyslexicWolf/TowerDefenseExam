

namespace StatePattern
{
    public class StateMachine
    {
        public IState CurrentState;

        public StateMachine(IState startState)
        {
            CurrentState = startState;
            CurrentState.OnEnter();
        }

        public void Update(float deltaTime)
        {
            CurrentState.Update(deltaTime);
        }

        public void MoveToState(IState newState)
        {
            if (newState != CurrentState)
            {
                CurrentState.OnExit();
                CurrentState = newState;
                CurrentState.OnEnter();
            }            
        }
    }
}
