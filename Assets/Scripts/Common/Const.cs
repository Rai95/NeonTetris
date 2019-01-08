using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeonTetris.Common
{
    class Const
    {
        public const int MAX_COLUMN_COUNT = 10;             //最大列数
        public const int MAX_ROW_COUNT = 20;                //最大行数
        public const float BRICK_SIZE = 0.64f;              //砖块位置偏移量
        public const float DEFAULT_TICK_INTERVAL = 1.0f;    //默认回合间隔
    }

    public enum Direction
    {
        Up = 0,
        Left = 1,
        Down = 2,
        Right = 3,
    }

    public struct PosPair
    {
        public float posX;
        public float posY;

        public PosPair(float x, float y)
        {
            posX = x;
            posY = y;
        }
    }
}

