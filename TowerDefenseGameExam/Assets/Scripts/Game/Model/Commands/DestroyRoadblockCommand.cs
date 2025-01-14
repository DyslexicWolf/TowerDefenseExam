using CommandPattern;
using MapSystem.Model;
using TowerDefense.Model;

public class DestroyRoadblockCommand: ITimedCommand<GameModel>
{
    private readonly CellModel _cell;
    public float Time { get; }

    public DestroyRoadblockCommand(float time, CellModel cell)
    {
        _cell = cell;
        Time = time;
    }

    public void Execute(GameModel context)
    {
        context.DestoryRoadblock(_cell);
    }

    public void Undo(GameModel context)
    {
        throw new System.NotImplementedException();
    }
}
