using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race
{
    /// <summary>
    /// 属性值
    /// 未来可用“自定义属性值”的变体规则
    /// </summary>
    /// <remarks>属性值</remarks>
    public class DetermineAbility
    {
        /// <summary>
        /// 力量
        /// </summary>
        private int strength;
        /// <summary>
        /// 敏捷
        /// </summary>
        private int dexterity;
        /// <summary>
        /// 体质
        /// </summary>
        private int constitution;
        /// <summary>
        /// 智力
        /// </summary>
        private int intelligence;
        /// <summary>
        /// 感知
        /// </summary>
        private int wisdom;
        /// <summary>
        /// 魅力
        /// </summary>
        private int charisma;

        /// <summary>
        /// 力量
        /// </summary>
        public int Strength { get => strength; set => strength = value; }
        /// <summary>
        /// 敏捷
        /// </summary>
        public int Dexterity { get => dexterity; set => dexterity = value; }
        /// <summary>
        /// 体质
        /// </summary>
        public int Constitution { get => constitution; set => constitution = value; }
        /// <summary>
        /// 智力
        /// </summary>
        public int Intelligence { get => intelligence; set => intelligence = value; }
        /// <summary>
        /// 感知
        /// </summary>
        public int Wisdom { get => wisdom; set => wisdom = value; }
        /// <summary>
        /// 魅力
        /// </summary>
        public int Charisma { get => charisma; set => charisma = value; }
    }
}