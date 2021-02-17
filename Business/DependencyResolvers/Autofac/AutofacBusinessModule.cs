using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //proje start ile birlikte bu metod çalışacak
        protected override void Load(ContainerBuilder builder)
        {
            //Birisi senden IProductService isterse, ona productmanager instanceı yarat ve ver. Tek bir instance 
            //tüm proje ile paylaşılır. Bu class'ın data tutmadığını bildiğimiz için tek instance kullanılabilir.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();


        }
    }
}
