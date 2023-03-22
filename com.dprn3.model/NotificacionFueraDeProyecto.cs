using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionFueraDeProyecto : Mensaje
    {
        MensajePersonalizado_5 fueraProyecto = null;

        public void MensajePersonalizado()
        {
            fueraProyecto = new MensajePersonalizado_5();
            fueraProyecto.Show();
        }
    }
}
