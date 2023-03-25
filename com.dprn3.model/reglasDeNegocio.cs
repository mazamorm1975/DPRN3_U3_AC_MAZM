using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using System;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class reglasDeNegocio
    {


        //Se valida si el empleado puede ser asignado a un proyecto
        public static void ValidacionAsignacionEmpleadoProyecto()
        {

            for (int i = 0; i < clsAltaInformacion.contarTotalRegistrosEmpleadosAsignados(); i++)
            {
                //Se valida el proyecto
                if (clsAltaInformacion.ValidaciónIngresoNuevoProyecto() == true)
                {

                    if (clsAltaInformacion.ubicaEmpleado() == false)
                    {
                        //Verifica si el empleado es Programador
                        Boolean isProgrammer = clsAltaInformacion.ValidaSiesRolDeProgramador();
                        if (isProgrammer.Equals(true))
                        {
                            clsAltaInformacion validaLimiteDesarrollador = new clsAltaInformacion();
                            int limiteP = validaLimiteDesarrollador.MatrixToFilterProgrammersOnly();

                            if (limiteP == 3)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloProgramador());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un desarrollador lo inserta y sale del bucle
                                clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(frmAsignacionProyectos.noEmpleado, frmAsignacionProyectos.idProyecto, frmAsignacionProyectos.asignacionEmpleado, frmAsignacionProyectos.comentarios);
                                break;

                            }
                        }

                        //Verifica si el empleado es Lider De Proyecto
                        Boolean isTechLeader = clsAltaInformacion.ValidaSiesRolDeLiderDeProyecto();
                        if (isTechLeader.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterProjectLeadersOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFallo());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un lider de proyecto lo inserta y sale del bucle
                                clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(frmAsignacionProyectos.noEmpleado, frmAsignacionProyectos.idProyecto, frmAsignacionProyectos.asignacionEmpleado, frmAsignacionProyectos.comentarios);
                                break;

                            }
                        }

                        //Verifica si el empleado es Analista
                        Boolean isAnalista = clsAltaInformacion.ValidaSiesRolDeAnalista();
                        if (isAnalista.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterAnalystOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de Analistas
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloAnalistas());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un analista lo inserta y sale del bucle
                                clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(frmAsignacionProyectos.noEmpleado, frmAsignacionProyectos.idProyecto, frmAsignacionProyectos.asignacionEmpleado, frmAsignacionProyectos.comentarios);
                                break;

                            }
                        }
                    }
                    else
                    {
                        //si ubica al empleado lanza mensaje de que no puede estar en 2 proyectos activos
                        Notificacion excedePosicion = new Notificacion(new NotificacionExcedeNumeroEmpleados());
                        excedePosicion.MostrarMensaje();
                        break;
                    }

                    /* Descomentar de la linea 101 - 182 en caso de requerir el validar
                     * el status de asignado = 0 ó asignado = 1 del empleado en el proyecto especificado
                    
                    //Si el status del empleado es 0
                    if (clsAltaInformacion.isAssigned() == false)
                    {
                        //Verifica si el empleado es Programador
                        Boolean isProgrammer = clsAltaInformacion.ValidaSiesRolDeProgramador();
                        if (isProgrammer.Equals(true))
                        {
                            clsAltaInformacion validaLimiteDesarrollador = new clsAltaInformacion();
                            int limiteP = validaLimiteDesarrollador.MatrixToFilterProgrammersOnly();

                            if (limiteP == 3)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloProgramador());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un desarrollador lo inserta y sale del bucle
                                clsAltaInformacion.actualizaInformaciónProyecto();
                                break;
                            }
                        }

                        //Verifica si el empleado es Lider De Proyecto
                        Boolean isTechLeader = clsAltaInformacion.ValidaSiesRolDeLiderDeProyecto();
                        if (isTechLeader.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterProjectLeadersOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFallo());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un lider de proyecto lo inserta y sale del bucle
                                clsAltaInformacion.actualizaInformaciónProyecto();
                                break;

                            }
                        }

                        //Verifica si el empleado es Analista
                        Boolean isAnalista = clsAltaInformacion.ValidaSiesRolDeAnalista();
                        if (isAnalista.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterAnalystOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de Analistas
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloAnalistas());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un analista lo inserta y sale del bucle
                                clsAltaInformacion.actualizaInformaciónProyecto();
                                break;

                            }
                        }

                        clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(frmAsignacionProyectos.noEmpleado, frmAsignacionProyectos.idProyecto, frmAsignacionProyectos.asignacionEmpleado, frmAsignacionProyectos.comentarios);
                        break;

                    }   
                    //Si el status del empleado es 1
                     else if (clsAltaInformacion.isAssigned() == true)
                    {
                        //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                        Notificacion excedePosicion = new Notificacion(new NotificacionExcedeNumeroEmpleados());
                        excedePosicion.MostrarMensaje();
                        break;
                    }*/
                }
                else
                {
                    break;
                }
            }
        }





    }
}
