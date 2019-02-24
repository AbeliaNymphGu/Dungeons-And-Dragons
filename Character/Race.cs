using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Character;

namespace Race
{
    public class Race
    {
        /// <summary>
        /// 矮人
        /// </summary>
        public class Dwarf
        {
            /// <summary>
            /// 矮人种族特征
            /// </summary>
            private DwarfRacialTraits racialTraits;

            /// <summary>
            /// 黑暗视觉
            /// </summary>
            public void Darkvision()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 矮人体魄
            /// </summary>
            public void DwarvenResilience()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 矮人战斗训练
            /// </summary>
            public void DwavenCombatTraining()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 石中精妙
            /// </summary>
            public void Stonecunning()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 工具熟练项
            /// </summary>
            public void ToolProficiency()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 山地矮人
        /// </summary>
        public class MountainDwarf : Dwarf
        {
            /// <summary>
            /// 矮人护甲训练
            /// </summary>
            public void DwarvenArmorTraining()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 丘陵矮人
        /// </summary>
        public class HillDwarf : Dwarf
        {
            /// <summary>
            /// 矮人刚毅
            /// </summary>
            public void DwarvenToughness()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 精灵
        /// </summary>
        public class Elf
        {
            /// <summary>
            /// 精灵种族特征
            /// </summary>
            private ElfRacialTraits racialTraits;

            /// <summary>
            /// 黑暗视觉
            /// </summary>
            public void Darkvision()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 精灵血统
            /// </summary>
            public void FeyAncestry()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 敏锐感官
            /// </summary>
            public void KeenSences()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 出神
            /// </summary>
            public void Trance()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 高等精灵
        /// </summary>
        public class HighElf : Elf
        {

            /// <summary>
            /// 戏法
            /// </summary>
            public void Cantrip()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 精灵武器训练
            /// </summary>
            public void ElfWeaponTraining()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 额外语言
            /// </summary>
            public void ExtraLanguage()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 木精灵
        /// </summary>
        public class WoodElf : Elf
        {

            /// <summary>
            /// 精灵武器训练
            /// </summary>
            public void ElfWeaponTraining()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 轻盈步伐
            /// </summary>
            public void FleetOfFoot()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 野性面具
            /// </summary>
            public void MaskOfWild()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 半身人
        /// </summary>
        public class Halfling
        {
            /// <summary>
            /// 半身人种族特征
            /// </summary>
            private RalflingRacialTraits racialTraits;

            /// <summary>
            /// 勇气
            /// </summary>
            public void Brave()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 半身人灵巧
            /// </summary>
            public void HalflingNimbleness()
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// 幸运
            /// </summary>
            public void Lucky()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 轻足半身人
        /// </summary>
        public class Lightfoot : Halfling
        {
            /// <summary>
            /// 天生兽匿
            /// </summary>
            public void NaturallyStealthy()
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// 强心半身人
        /// </summary>
        public class Stout : Halfling
        {
            /// <summary>
            /// 敦实体魄
            /// </summary>
            public void StoutResilience()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}