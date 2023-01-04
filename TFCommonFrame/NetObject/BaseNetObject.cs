using System;

namespace TFCommonFrame.NetObject
{
    /// <summary>
    /// 基本消息类型
    /// </summary>
    [Serializable]
    public enum BaseNetObjectType
    {
        /// <summary>
        /// 系统消息
        /// </summary>
        SystemNetObject,
        /// <summary>
        /// 房间内消息
        /// </summary>
        RoomNetObject,
        /// <summary>
        /// 游戏消息
        /// </summary>
        GameNetObject,
    }

    /// <summary>
    /// 通讯信息基类
    /// </summary>
    [Serializable]
    public abstract class BaseNetObject
    {
        public BaseNetObjectType BaseNetObjectType;

        public BaseNetObject(BaseNetObjectType baseNetObjectType)
        {
            BaseNetObjectType = baseNetObjectType;
        }
    }
    /// <summary>
    /// 系统消息基类
    /// </summary>
    [Serializable]
    public abstract class SystemNetObject : BaseNetObject
    {
        public SystemNetObject() : base(BaseNetObjectType.SystemNetObject) { }
    }

    /// <summary>
    /// 游戏消息
    /// </summary>
    [Serializable]
    public abstract class RoomNetObject : BaseNetObject
    {
        public RoomNetObject() : base(BaseNetObjectType.GameNetObject)
        {

        }
    }

    /// <summary>
    /// 游戏消息
    /// </summary>
    [Serializable]
    public abstract class GameNetObject : RoomNetObject
    {
        public GameNetObject()
        {
            BaseNetObjectType = BaseNetObjectType.GameNetObject;
        }
    }

    /// <summary>
    /// 游戏组件同步消息
    /// 将转发给对应组件处理
    /// </summary>
    [Serializable]
    public abstract class ComponentSynNetObject : GameNetObject
    {
        /// <summary>
        /// 组件ID
        /// </summary>
        public Guid ComponentId;

        /// <summary>
        /// 组件所在位置的全名
        /// </summary>
        public string ComponentName;

        public ComponentSynNetObject(Guid id,string componentName)
        {
            ComponentId = id;
            ComponentName = componentName;
        }
    }
}
