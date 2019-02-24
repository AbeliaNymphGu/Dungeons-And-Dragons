using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Character
{
    /// <summary>
    /// 调整值
    /// 详查《属性调整值》
    /// 若某个属性值数值未包含在表内，请将该属性值减10，再将结果除以2（向下取整）
    /// </summary>
    /// <remarks>调整值</remarks>
    public class Modifiers
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
    }
}