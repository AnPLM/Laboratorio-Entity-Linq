using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;


namespace DAO
{
    public class DAOHandler
    {
        private EmpresaEntities context;


        public List<TO.ClienteTO> getClients()
        {

            var query = (from clients in context.Clientes
                        select clients).ToList();

            List<ClienteTO> list = new List<ClienteTO>();
            ClienteTO clienteTO = new ClienteTO();
            foreach (Cliente client in query)
            {
                clienteTO.Nombre = client.Nombre;
                clienteTO.Telefono = client.Telefono;
                clienteTO.Correo = client.Correo;
                clienteTO.Cedula = client.Cedula;
                clienteTO.Apellido = client.Apellido;
                list.Add(clienteTO);
            }
            return list;
        }
    }
}
