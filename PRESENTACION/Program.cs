
using _01_APLICACION;
using _01_APLICACION.DTO;
using Autofac;
using _00_PRESENTACION.IoC_Container;

try
    {
        IContainer container = Container.GetContainer();

        ClienteDTO Alexis = new ClienteDTO(
            Guid.NewGuid(),
            "Alexis",
            "Paiva",
            "alexis@paiva.com"
            );

        ClienteDTO Luis = new ClienteDTO(
            Guid.NewGuid(),
            "Luis",
            "Blanco",
            "luis@blanco.com"
            );

        ClienteDTO Paula = new ClienteDTO(
            Guid.NewGuid(),
            "Paula",
            "Berghella",
            "paula@berghella.com"
            );

    CrearCliente creadorDeClientes = container.Resolve<CrearCliente>();
    creadorDeClientes.Ejecutar(Alexis);
    creadorDeClientes.Ejecutar(Luis);
    creadorDeClientes.Ejecutar(Paula);

    ObtenerClientes obtenedorDeClientes = container.Resolve<ObtenerClientes>();

    List<ClienteDTO> todosLosClientes = obtenedorDeClientes.Ejecutar();

    ObtenerClientePorId obtenedorDeUnSoloCliente = container.Resolve<ObtenerClientePorId>();

    ActualizarEmail actualizadorDeEmail = container.Resolve<ActualizarEmail>();

    EliminarCliente eliminadorDeCliente = container.Resolve<EliminarCliente>();

    foreach (ClienteDTO cliente in todosLosClientes)
        {
            Console.WriteLine(
                "ID: " + cliente.Id() +
                "\n-----------------------------------------\n" +
                cliente.Presentacion());
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
