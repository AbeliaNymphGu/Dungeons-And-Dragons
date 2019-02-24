using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Character
{
    /// <summary>
    /// 种族特质
    /// 各种种族普遍拥有的特质，可做其它种族特质的基类
    /// </summary>
    /// <remarks>种族特质</remarks>
    public abstract class RacialTraits
    {
        /// <summary>
        /// 年龄
        /// </summary>
        private Age age;
        /// <summary>
        /// 属性值加成
        /// </summary>
        private AbilityScoreIncreace abilityScoreIncrease;
        /// <summary>
        /// 阵营
        /// </summary>
        private Alignment Alignment;
        /// <summary>
        /// 体型
        /// </summary>
        private Size size;
        /// <summary>
        /// 速度
        /// </summary>
        private Speed speed;
        /// <summary>
        /// 语言
        /// </summary>
        private LanguagesAbility languages;
    }
}