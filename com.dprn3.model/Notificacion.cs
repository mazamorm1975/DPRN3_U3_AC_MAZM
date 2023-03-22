namespace DPRNIII_U2_A1_MAZM.com.dprn3.interfaces
{
    class Notificacion
    {
        private Mensaje msg;

        public Notificacion(Mensaje msg)
        {
            this.msg = msg;
        }

        public void MostrarMensaje()
        {
            msg.MensajePersonalizado();
        }
    }
}
