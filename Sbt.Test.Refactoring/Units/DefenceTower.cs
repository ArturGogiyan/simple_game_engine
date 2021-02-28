using Sbt.Test.Refactoring.Commands;

namespace Sbt.Test.Refactoring.Units {
    public class DefenceTower : MaterialUnitBase {
        public Orientation Orientation { get; private set; }

        public DefenceTower(Map map, Coordinates position) : base(map, position) { }

        public int CartrigesAmount { get; private set; }

        public override void ExecuteCommand(CommandBase command) {
            base.ExecuteCommand(command);
            if (command is FireCommand)
                Fire();
            if (command is TurnClockwiseCommand)
                TurnClockwise();
        }

        private void Fire() {
            CartrigesAmount--;
        }

        private void TurnClockwise()
        {
            Orientation = (Orientation)(((int)Orientation + 1) % 4);
        }
    }
}
