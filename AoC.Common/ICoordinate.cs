namespace AoC.Common;

public interface ICoordinate
{
    int Id { get; }
    Coordinate Coordinate { get; set; }
}