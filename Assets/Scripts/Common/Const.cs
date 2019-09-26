using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace NeonTetris.Common
{
    class Const
    {
        public const int MAX_COLUMN_COUNT = 10;             //最大列数
        public const int MAX_ROW_COUNT = 20;                //最大行数
        public const float BRICK_SIZE = 0.64f;              //砖块位置偏移量
        public const float DEFAULT_TICK_INTERVAL = 1.0f;    //默认回合间隔
        public const int ROTATE_DIRECTION = -1;             //旋转方向

        public const string BRICK_PREFAB_PATH = "Bricks/Brick";         //砖块预制体的位置

        public Color Blue = new Color(0.25f,0.25f,1f);
        public Color Cyan = new Color(0f, 1f, 1f);
        public Color Green = new Color(0.125f, 1f, 0.125f);
        public Color Orange = new Color(1f, 0.375f, 0f);
        public Color Purple = new Color(1f, 0.125f, 1f);
        public Color Red = new Color(1f, 0.125f, 0.125f);
        public Color Yellow = new Color(1f, 1f, 0.125f);
    }

    public enum Direction
    {
        Up = 0,
        Left = 1,
        Down = 2,
        Right = 3,
    }

    public struct Position
    {
        public float x;
        public float y;

        public Position(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

