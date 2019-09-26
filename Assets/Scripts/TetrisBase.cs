using NeonTetris.Common;
using System.Collections.Generic;
using UnityEngine;

public abstract class TetrisBase
{
    private Position pos = new Position(0, 0);
    public Position Pos
    {
        get { return pos; }
    }

    private Direction dir = Direction.Up;
    public Direction Dir
    {
        get { return dir; }
    }

    private Color brickColor = Color.white;
    public Color BrickColor
    {
        get { return brickColor; }
    }

    public TetrisBase(Position p, Direction d)
    {
        pos = p;
        dir = d;
    }

    public abstract IEnumerator<Position> GetPosList();

    public void Move(Direction d)
    {
        switch (d)
        {
            case Direction.Up: { break; }
            case Direction.Left: { pos.x -= 1; break; }
            case Direction.Down: { pos.y -= 1; break; }
            case Direction.Right: { pos.x += 1; break; }
        }
    }

    public void Rotate(Direction d)
    {
        switch (d)
        {
            case Direction.Left: { dir = dir - 1 < Direction.Up ? Direction.Right : dir - 1; break; }
            case Direction.Right: { dir = dir + 1 > Direction.Right ? Direction.Up : dir + 1; break; }
        }
    }

}
