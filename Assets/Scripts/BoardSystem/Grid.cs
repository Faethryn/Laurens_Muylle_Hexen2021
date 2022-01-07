﻿using DAE.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DAE.BoardSystem
{
    public class Grid<TPosition>
    {

        public int Rows { get; }

        public int Columns { get; }

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        private BidirectionalDictionary<(int x, int y), TPosition> _positions = new BidirectionalDictionary<(int, int), TPosition>();
        public bool TryGetPositionAt(int x, int y, out TPosition position)
            => _positions.TryGetValue((x, y), out position);

        public bool TryGetCoordinateOf(TPosition position, out (int x, int y) coordinate)
           => _positions.TryGetKey(position, out coordinate);


        public void Register(int x, int y, TPosition position)
        {

#if UNITY_EDITOR

#endif
           
            Debug.Log((x, y));
            _positions.Add((x,y), position);
        }
    }
}