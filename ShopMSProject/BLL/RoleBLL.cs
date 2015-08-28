using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using DALFactory;

namespace BLL
{
    /// <summary>
    /// 角色的业务逻辑层，xh.yang
    /// 业务逻辑RoleBLL说明
    /// </summary>

    public class RoleBLL
    {
        private readonly InterfaceRoleDAL iRoleDal = DALFactory.DBFactoryDAL.CreateInterfaceRoleDAL();
        public RoleBLL() { }

        #region 是否存在角色记录
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string RoleID)
        {
            return iRoleDal.Exists(RoleID);
        }
        #endregion
    }
}
