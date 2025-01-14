using UnityEngine;
using TowerDefense.Model;
using TowerDefense.Presenter;
using UnityEngine.UIElements;
using TowerDefense.View;
using TowerDefense.View.States;

public class UILogic : MonoBehaviour
{
    public int numberOfEnemies;
    public int goalHealth;
    private GamePresenter gamePresenter;
    public UIDocument uiDocument;
    public int totalEnemyHealth;
    public float time;
    public GameStateSystem gameStateSystem;

    void Start()
    {
        gamePresenter = GameObject.FindAnyObjectByType<GamePresenter>();
        gameStateSystem = GameObject.Find("GameStateSystem").GetComponent<GameStateSystem>();
    }

    void Update()
    {
        numberOfEnemies = gamePresenter.Model.SpawnedEnemies;
        goalHealth = gamePresenter.Model.Goal.Health;
        foreach (var enemy in gamePresenter.Model.Enemies)
        {
            totalEnemyHealth += enemy.Health;
        }
        if (!(gameStateSystem.StateMachine.CurrentState == gameStateSystem.PauseState))
        {
            time += Time.deltaTime;
        }
        uiDocument.rootVisualElement.Q<Label>("NumberOfEnemies").text = $"Number of enemies: {numberOfEnemies}";
        uiDocument.rootVisualElement.Q<Label>("GoalHealth").text = $"Goal Health: {goalHealth}% ";
        uiDocument.rootVisualElement.Q<Label>("TotalEnemyHealth").text = $"Total Enemy Health: {totalEnemyHealth}";
        uiDocument.rootVisualElement.Q<Label>("Time").text = $"Time: {(int)time / 60:00}:{time % 60:00}";
    }
}
