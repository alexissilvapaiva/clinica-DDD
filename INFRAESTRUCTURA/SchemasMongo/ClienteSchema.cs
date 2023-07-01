//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace _03_INFRAESTRUCTURA.SchemasMongo
{
   public class ClienteSchema
    { 
            [BsonId]
            public Guid Id { get; set; }
            public String Nombre { get; set; }
            public String Apellido { get; set; }
            public String Email { get; set; }
       
    }
}
