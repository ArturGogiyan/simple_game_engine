using Sbt.Test.Refactoring.Commands;

namespace Sbt.Test.Refactoring {
    public class Tractor : Units.Tractor {

        public Tractor() : base(new Map(5, 5), new Coordinates { X = 0, Y = 0 }) { }

        public void Move(string command) {
            if (command == "F")
                ExecuteCommand(new MoveForwardCommand());
            else if (command == "T")
                ExecuteCommand(new TurnClockwiseCommand());
        }

        public int GetPositionX() { return (int)Position.X; }

        public int GetPositionY() { return (int)Position.Y; }
    }
}
