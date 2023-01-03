﻿using TFCommonFrame.NetObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFCommonFrame.Room
{
    /// <summary>
    /// 表示房间的配置信息
    /// </summary>
    [Serializable]
    public abstract class BaseRoomDesc
    {
        //最大容纳人数
        public int MaxPlayerNum;

        //房间Id号
        public int ID;

        public override string ToString()
        {
            return " RoomID : " + ID;
        }

    }
}
