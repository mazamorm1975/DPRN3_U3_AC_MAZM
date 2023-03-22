using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionExcedeNumeroEmpleados : Mensaje
    {
        MensajePersonalizado_6 excedePosicion = null;

        public void MensajePersonalizado()
        {
            excedePosicion = new MensajePersonalizado_6();
            excedePosicion.Show();
        }
    }
}
