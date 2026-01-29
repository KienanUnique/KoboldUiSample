using System.Collections.Generic;
using Utils;

namespace Services.LevelProgression
{
    public interface ILevelProgressionService
    {
        IReadOnlyList<LevelData> Progression { get; }
    }
}