using Entity;
using Sephiroth_DAO;

/*************************************************************************************
    * CLR 版本：       4.0.30319.33440
    * 类 名 称：       SYS_USER
    * 机器名称：       DESKTOP-BBO396R
    * 命名空间：       DAO
    * 文 件 名：       SYS_USER
    * 创建时间：       2016-07-18 10:54
    * 作    者：       
    * 说    明：           <!--数据链接-->
    *                      <add key="dbtype" value="MSSQL\ORACLE\MYSQL" />
    *                      <add key="dbsource" value="数据库服务名称" />
    *                      <add key="datasource" value="数据库名称" />
    *                      <add key="username" value="用户名" />
    *                      <add key="password" value="密码" />
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace DAO
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class SYS_USER_DAO : BaseDAO<SYS_USER>
    {
        private Sephiroth_IDao.IDAO dao = new DapperDAO(Sephiroth_DAO.CreateDB_Connection.GetSephiroth_System());

        public override Sephiroth_IDao.IDAO absORM 
        {
            get { return dao; }
            set { dao = value; }
        }

    }
}

