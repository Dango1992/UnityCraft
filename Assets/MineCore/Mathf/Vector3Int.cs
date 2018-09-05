using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dango.UnityCraft
{
    public class Vector3Int
    {
        public int x;
        public int y;
        public int z;

        public Vector3Int(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #region Common Vector3 Size
        public static Vector3Int Zero
        {
            get
            {
                return new Vector3Int(0, 0, 0);
            }
        }

        public static Vector3Int One
        {
            get
            {
                return new Vector3Int(1, 1, 1);
            }
        }

        public static Vector3Int Standard
        {
            get
            {
                return new Vector3Int(GlobalBlocks.StandardSize, GlobalBlocks.StandardSize, GlobalBlocks.StandardSize);
            }
        }
        #endregion

    }
}