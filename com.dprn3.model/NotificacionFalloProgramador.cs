using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionFalloProgramador : Mensaje
    {
        MensajePersonalizado_3 limiteProgramador = null;

        public void MensajePersonalizado()
        {
            limiteProgramador = new MensajePersonalizado_3();
            limiteProgramador.Show();
        }
    }
}
