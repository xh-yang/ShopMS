using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    /// <summary>
    /// 角色操作接口， xh.yang
    /// </summary>

    public interface InterfaceRoleDAL
    {
        #region 成员方法

        //是否存在该记录
        bool Exists(string RoleID);
        //添加纪录
        bool Add(Model.RoleModel Model);

        #endregion 成员方法
    }
}
