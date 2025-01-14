using System;

namespace TowerDefense.Model
{
    public class RoadblockModelEventArgs: EventArgs
    {
        public RoadblockModel RoadblockModel { get; }

        public RoadblockModelEventArgs(RoadblockModel roadblockModel)
        {
            RoadblockModel = roadblockModel;
        }
    }
}

