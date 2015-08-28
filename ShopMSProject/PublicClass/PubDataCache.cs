using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;


namespace PublicClass
{
   public class PubDataCache
   {
       #region 获取缓存
       /// <summary>
        /// 取得某缓存的值
        /// </summary>
        /// <param name="CacheKey">缓存的键</param>
        /// <returns>缓存的值</returns>
        
        public static object GetCache(string CacheKey)
        {
            Cache objCache = HttpRuntime.Cache;
            return objCache[CacheKey];
        }

       #endregion

        #region 设置缓存

        /// <summary>
        /// 设置某缓存的值
       /// </summary>
        /// <param name="CacheKey">缓存的键</param>

        public static void SetCache(string CacheKey,object obj)
        {
            Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, obj);
        }

        #endregion

    }
}
