using Sbt.Test.Refactoring.Commands;

namespace Sbt.Test.Refactoring.Units {
    public class Wind : UnitBase {
        public Orientation Orientation { get; set; }

        public Wind(Map map) : base(map) {
            Orientation = Orientation.North;
        }

        public override void ExecuteCommand(CommandBase command) {
            base.ExecuteCommand(command);

            if (command.GetType() != typeof(TurnClockwiseCommand)) 
                return;

            TurnClockwise();
        }

        private void TurnClockwise() {
            Orientation = (Orientation)(((int)Orientation + 1) % 4);
        }
    }
}
