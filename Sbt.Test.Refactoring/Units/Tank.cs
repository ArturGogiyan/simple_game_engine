using Sbt.Test.Refactoring.Commands;

namespace Sbt.Test.Refactoring.Units {
    public class Tank : Vehicle {
        public Tank(Map map, Coordinates position) : base(map, position) { }
        public int CartrigesAmount { get; private set; }

        public override void ExecuteCommand(CommandBase command) {
            base.ExecuteCommand(command);

            if (command is FireCommand)
                Fire();
        }

        private void Fire() {
            CartrigesAmount--;
        }

    }
}
