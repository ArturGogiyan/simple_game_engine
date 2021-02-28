using System;

namespace Sbt.Test.Refactoring.Units {
    public abstract class MaterialUnitBase : UnitBase {
        public Coordinates Position { get; protected set; }
        protected MaterialUnitBase(Map map, Coordinates position) : base(map) {
            if (position.X > Map.Width || position.Y > Map.Height)
                throw new ArgumentOutOfRangeException(nameof(position));
            Position = position;
        }
    }
}
