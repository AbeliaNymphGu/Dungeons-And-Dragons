using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race
{
    /// <summary>
    /// 姓名
    /// 用于表示人物姓名
    /// </summary>
    /// <remarks>名字</remarks>
    public class Name
    {
        /// <summary>
        /// 姓氏
        /// </summary>
        private string surname;
        /// <summary>
        /// 名字
        /// </summary>
        private string forename;

        /// <summary>
        /// 名字属性
        /// </summary>
        public string ContainSurname
        {
            get => default(string);
            set
            {
            }
        }

        /// <summary>
        /// 姓氏属性
        /// </summary>
        public string ContainForename
        {
            get => default(string);
            set
            {
            }
        }
    }
}