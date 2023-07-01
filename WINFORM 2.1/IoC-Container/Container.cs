using _01_APLICACION;
using _02_DOMINIO.Repositorio;
using _03_INFRAESTRUCTURA;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_PRESENTACION_WINFORM.IoC_Container
{
    static public class Container
    {
        static public IContainer GetMongoDBContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioMongoDb>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerClientes>();
            builder.RegisterType<ObtenerClientePorId>();
            builder.RegisterType<EliminarCliente>();
            builder.RegisterType<ActualizarEmail>();
            IContainer container = builder.Build();

            return container;
        }

        static public IContainer GetSQLContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioSQL>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerClientes>();
            builder.RegisterType<ObtenerClientePorId>();
            builder.RegisterType<EliminarCliente>();
            builder.RegisterType<ActualizarEmail>();
            IContainer container = builder.Build();

            return container;
        }

        static public IContainer GetEntityFrameworkContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioEntityFramework>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerClientes>();
            builder.RegisterType<ObtenerClientePorId>();
            builder.RegisterType<EliminarCliente>();
            builder.RegisterType<ActualizarEmail>();
            IContainer container = builder.Build();

            return container;
        }
    }
}
