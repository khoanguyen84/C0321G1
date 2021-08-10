using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CGShop.Service
{
    public class BaseService
    {
        protected IDbConnection connection;
        public BaseService()
        {
            connection = new SqlConnection(@"Data Source=admin\sqlexpress;Initial Catalog=CGShopDB;Integrated Security=True");
        }
    }
}
