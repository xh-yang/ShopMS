using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
using IDAL;


namespace MySQLDbDAL
{
    /// <summary>
    /// mysql 数据库操作逻辑，xh.yang
    /// 继承接口
    /// </summary>

    public class MySQLRoleDAL : InterfaceRoleDAL
    {
        public MySQLRoleDAL()
        { 
        
        }

        #region 角色是否存在

        /// <summary>
        /// 根据ID判断角色是否存在
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        /// <returns></returns>

        public bool Exists(string RoleID)
        {
            return false;
        }

        #endregion 角色是否存在

        #region 添加角色
        public bool Add(Model.RoleModel RoleModel)
        {
            return false;
        }
        #endregion 添加角色
    }
}
