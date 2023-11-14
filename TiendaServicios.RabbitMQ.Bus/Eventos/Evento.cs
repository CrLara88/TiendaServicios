using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaServicios.RabbitMQ.Bus.Eventos
{
    public abstract class Evento
    {
        public DateTime TimeStamp { get; protected set; }

        protected Evento()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
