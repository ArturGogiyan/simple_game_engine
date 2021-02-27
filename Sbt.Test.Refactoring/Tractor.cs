using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public class Tractor
    {
        private int[] _position = new int[] { 0, 0 };
        private int[] _field = new int[] { 5, 5 };
        private Orientation _orientation = Orientation.North;

        public Orientation Orientation
        {
            get 
            {
                return _orientation;
            }
        }

        public void Move(string command)
        {
            if (command == "F")
            {
                MoveForwards();
            }
            else if (command == "T")
            {
                TurnClockwise();
            }
        }

        private void MoveForwards()
        {
            if (_orientation == Orientation.North)
            {
                _position = new int[] { _position[0], _position[1] + 1 };
            }
            else if (_orientation == Orientation.East)
            {
                _position = new int[] { _position[0] + 1, _position[1] };
            }
            else if (_orientation == Orientation.South)
            {
                _position = new int[] { _position[0], _position[1] - 1 };
            }
            else if (_orientation == Orientation.West)
            {
                _position = new int[] { _position[0] - 1, _position[1] };
            }

            if (_position[0] > _field[0] || _position[1] > _field[1])
            { 
                throw new TractorInDitchException();
            }
        }

        private void TurnClockwise()
        {
            if (_orientation == Orientation.North)
            {
                _orientation = Orientation.East;
            }
            else if (_orientation == Orientation.East)
            {
                _orientation = Orientation.South;
            }
            else if (_orientation == Orientation.South)
            {
                _orientation = Orientation.West;
            }
            else if (_orientation == Orientation.West)
            {
                _orientation = Orientation.North;
            }
        }

        public int GetPositionX()
        {
            return _position[0];
        }

        public int GetPositionY()
        {
            return _position[1];
        }
    }
}
