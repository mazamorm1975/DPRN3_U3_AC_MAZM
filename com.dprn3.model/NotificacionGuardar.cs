using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;


namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionGuardar : Mensaje
    {
        MensajePersonalizado msgPersonalizado = null;

        public void MensajePersonalizado()
        {
            msgPersonalizado = new MensajePersonalizado();
            msgPersonalizado.Show();
        }
    }
}
