using Sbt.Test.Refactoring.Commands;
using System;
using System.Collections.Generic;

namespace Sbt.Test.Refactoring.Units {
    public class Vehicle : MaterialUnitBase
    {
        public Orientation Orientation { get; private set; }
        private Dictionary<Type, Action> actions = new Dictionary<Type, Action>();

        public Vehicle(Map map, Coordinates position) : base(map, position)
        {
            Orientation = Orientation.North;

            actions = new Dictionary<Type, Action>();
            actions[typeof(MoveForwardCommand)] = () => MoveForward();
            actions[typeof(TurnClockwiseCommand)] = () => TurnClockwise();
        }

        public override void ExecuteCommand(CommandBase command)
        {
            base.ExecuteCommand(command);

            var commandType = command.GetType();

            if (!actions.ContainsKey(commandType))
            {
                return;
            }

            actions[commandType]();
        }

        private void MoveForward()
        {
            switch (Orientation) {
                case Orientation.East: 
                    Position = new Coordinates(Position.X + 1, Position.Y);
                    break;
                case Orientation.West:
                Position = new Coordinates(Position.X - 1 , Position.Y);
                    break;
                case Orientation.South:
                Position = new Coordinates(Position.X , Position.Y - 1);
                    break;
                case Orientation.North:
                Position = new Coordinates(Position.X, Position.Y + 1);
                    break;
            }

            if (Position.X > Map.Width || Position.Y > Map.Height)
            { 
                throw new TractorInDitchException();
            }
        }

        private void TurnClockwise()
        {
            Orientation = (Orientation)(((int)Orientation + 1) % 4);
        }
    }
}
