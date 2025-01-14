using MapSystem.Model;
using StatePattern;
using System;
using System.Collections.Generic;

namespace TowerDefense.Model
{
    public class RoadblockModel: ModelBase, IPlaceableModel
    {
        public CellModel CellBelow { get; set; }
        //public List<CellModel> WatchedCells { get; private set; }

        public RoadblockModel(CellModel cellBelow/*, List<CellModel> roadCells*/)
        {
            CellBelow = cellBelow;
            //WatchedCells = new List<CellModel>();

            //foreach (var cell in roadCells)
            //{
            //    if (CellBelow.Position.IsAdjacentTo(cell.Position))
            //    {
            //        WatchedCells.Add(cell);
            //    }
            //}
        }

        public void DestroyPresenter()
        {
            OnDestroySelf();
        }

    }
}

