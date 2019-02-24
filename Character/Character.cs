using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race
{
    public class Character
    {
        /// <summary>
        /// 姓名
        /// </summary>
        private Name name;
        /// <summary>
        /// 性别
        /// </summary>
        private Gender gender;
        /// <summary>
        /// 种族
        /// </summary>
        private Race race;
        /// <summary>
        /// 职业
        /// </summary>
        private Profession profession;
        /// <summary>
        /// 属性值
        /// </summary>
        private DetermineAbility determineAbilityScores;
        /// <summary>
        /// 理想
        /// </summary>
        private Ideal ideals;
        /// <summary>
        /// 牵绊
        /// </summary>
        private Bond bonds;
        /// <summary>
        /// 缺点
        /// </summary>
        private Flaw flaws;
        /// <summary>
        /// 背景
        /// </summary>
        private Background background;
        /// <summary>
        /// 装备
        /// </summary>
        private Equipment equipment;
    }
}