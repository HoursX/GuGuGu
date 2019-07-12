using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuGuGu
{
    public class Status
    {
        /// <summary>
        /// 获取错误信息
        /// </summary>
        /// <param name="ErrorCode">错误代码</param>
        /// <returns>返回错误信息</returns>
        public static string GetStatus(int ErrorCode)
        {
            switch (ErrorCode)
            {
                case 0:      return "数据库连接成功";
                case -1:     return "数据库连接失败";
                default:     return "未知错误";
            }
        }
    }
}
