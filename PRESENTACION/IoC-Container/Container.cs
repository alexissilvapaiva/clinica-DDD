using _01_APLICACION;
using Autofac;
using _02_DOMINIO.Repositorio;
using _03_INFRAESTRUCTURA;

namespace _00_PRESENTACION.IoC_Container
{
   static public class Container
    {
        static public IContainer GetContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioEnMemoria>().As<ClienteRepositorio>().SingleInstance();

            //para SQL Server:
            //builder.RegisterType<ClienteRepositorioSQL>().As<ClienteRepositorio>().SingleInstance();

            //para MongoDB:
            //builder.RegisterType<ClienteRepositorioMongoDb>().As<ClienteRepositorio>().SingleInstance();

            builder.RegisterType<ActualizarEmail>();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<EliminarCliente>();
            builder.RegisterType<ObtenerClientes>();
            builder.RegisterType<ObtenerClientePorId>();

            IContainer container = builder.Build();

            return container;
        }
    }
}
