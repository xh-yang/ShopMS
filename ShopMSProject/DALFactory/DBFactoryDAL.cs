using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;
using System.Data;
using IDAL;
using Maticsoft.DBUtility;

namespace DALFactory
{
    /// <summary>
    /// 数据库选择操作，xh.yang
    /// 如果在这里创建对象报错，请检查app.config里是否修改了<add key="DAL" value="MySQLDbDAL" />。
    /// </summary>

     
    public sealed class DBFactoryDAL
    {
        private static readonly string AssemblyPath = ConfigurationSettings.AppSettings["ADL"];
        public DBFactoryDAL() { }

        #region 不使用缓存

        /// <summary>
        /// 不使用缓存
        /// </summary>
        /// <param name="AssemblyPath">程序集路径</param>
        /// <param name="classNamespace">类的命名空间</param>
        /// <returns></returns>

        private static object CreateObjectNoCache(string AssemblyPath, string classNamespace)
        {
            try
            {
                object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                return objType;
            }
            catch//(System.Exception ex)
            {
                //string str=ex.Message;// 记录错误日志
                return null;
            }

        }
        #endregion

        #region 使用缓存
        private static object CreateObject(string AssemblyPath, string classNamespace)
        {
            object objType = PublicClass.PubDataCache.GetCache(classNamespace);
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                    PublicClass.PubDataCache.SetCache(classNamespace, objType);// 写入缓存
                }
                catch//(System.Exception ex)
                {
                    //string str=ex.Message;// 记录错误日志
                }
            }
            return objType;
        }
        #endregion

        
        #region 系统管理
        /// <summary>
        /// 创建系统管理接口，数据层面的
        /// </summary>
        /// <returns>系统管理接口</returns>
        public static IDAL.ISysManage CreateSysManage()
        {     
            string classNamespace = AssemblyPath + ".SysManage";
            object objType = CreateObject(AssemblyPath, classNamespace);
            return (IDAL.ISysManage)objType;
        }
        #endregion

        #region 创建角色接口
        /// <summary>
        /// 创建角色接口,数据层面的
        /// </summary>
        /// <returns>角色接口</returns>
        public static IDAL.InterfaceRoleDAL CreateInterfaceRoleDAL()
        {
            string classNamespace = AssemblyPath + ".InterfaceRoleDAL";
            object objType = CreateObject(AssemblyPath, classNamespace);
            return (IDAL.InterfaceRoleDAL)objType;
        }
        #endregion 创建角色接口

    }
}
