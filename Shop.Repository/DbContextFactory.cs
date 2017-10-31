using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////////////////////////////
using Shop.Model;
using System.Runtime.Remoting.Messaging;

namespace Shop.Repository
{
    public class DbContextFactory
    {
        //上下文对象工厂  实例化上下文对象
        public static Model1 CreateDbContext()
        {
            //安装程序包EntityFramework
            Model1 wxshop = CallContext.GetData("DbContext") as Model1;//查找上下文对象
            if (wxshop == null)//判断是否存在
            {
                wxshop = new Model1();
                CallContext.SetData("DbContext", wxshop);
                return wxshop;//不存在就实例化一个
            }
            return wxshop;//存在则直接返回
        }
    }
}
