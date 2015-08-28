using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 角色模型，xh.yang
    /// </summary>

    /// <summary>
    /// T_Role:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class RoleModel
    {
        public RoleModel()
        { }
        #region Model
        private string _roleid;
        private string _rolename;
        private string _comment;
        /// <summary>
        /// 角色编码
        /// </summary>
        public string RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName
        {
            set { _rolename = value; }
            get { return _rolename; }
        }
        /// <summary>
        /// 说明
        /// </summary>
        public string Comment
        {
            set { _comment = value; }
            get { return _comment; }
        }
        #endregion Model

    }
}
