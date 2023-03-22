using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionFalloAnalistas : Mensaje
    {
        MensajePersonalizado_4 limiteAnalistas = null;

        public void MensajePersonalizado()
        {
            limiteAnalistas = new MensajePersonalizado_4();
            limiteAnalistas.Show();
        }
    }
}
