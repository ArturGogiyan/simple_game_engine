namespace Sbt.Test.Refactoring {
    public struct Coordinates {
        public Coordinates(uint x, uint y) {
            X = x;
            Y = y;
        }
        public uint X { get; set; }
        public uint Y { get; set; }
    }
}
