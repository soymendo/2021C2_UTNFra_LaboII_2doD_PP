using System;
using System.Threading;
using Entidades;
using Entidades.Clases_especializadas;
using Entidades.Clases_generales;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Local local1 = new Local("Mendo", 10);



            Computadora aux = new Computadora();

            //Computadora c1 = new Computadora("C01", Petisiones.SoftwareInstalado.messenger, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.CounterStrike);
            //Computadora c2 = new Computadora("C02", Petisiones.SoftwareInstalado.ares, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.DiabloII);
            //Computadora c3 = new Computadora("C03", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.DiabloII);
            //Computadora c4 = new Computadora("C04", Petisiones.SoftwareInstalado.office, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.MuOnline);
            //Computadora c5 = new Computadora("C05", Petisiones.SoftwareInstalado.messenger, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.CounterStrike);
            //Computadora c6 = new Computadora("C06", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.DiabloII);
            //Computadora c7 = new Computadora("C07", Petisiones.SoftwareInstalado.ares, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.LineageII);
            //Computadora c8 = new Computadora("C08", Petisiones.SoftwareInstalado.office, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.MuOnline);
            //Computadora c9 = new Computadora("C09", Petisiones.SoftwareInstalado.messenger, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.DiabloII);
            //Computadora c10 = new Computadora("C10", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.CounterStrike);
            //Computadora c11 = new Computadora("C11", Petisiones.SoftwareInstalado.ares, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.CounterStrike);
            //Computadora c12 = new Computadora("C12", Petisiones.SoftwareInstalado.office, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.LineageII);
            //Computadora c13 = new Computadora("C13", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.MuOnline);
            //Computadora c14 = new Computadora("C14", Petisiones.SoftwareInstalado.messenger, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.CounterStrike);
            //Computadora c15 = new Computadora("C15", Petisiones.SoftwareInstalado.ares, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.LineageII);


            Cabina cab1 = new Cabina("T01",Cabina.TipoTelefono.ConTeclado,"Telecom","54-011-3245-2545");
            Cabina cab2 = new Cabina("T02", Cabina.TipoTelefono.ACuerda, "Telecom", "54-022-3245-2545");
            Cabina cab3 = new Cabina("T03", Cabina.TipoTelefono.ConTeclado, "Telecom", "44-011-3245-2545");









            Cliente cliente1 = new Cliente("oscar", "carabajal", 23456643, 35, Peticiones.SoftwareInstalado.icq, Peticiones.PeriféricosDisponibles.auriculares, (Peticiones.JuegosDisponibles)1);
            aux = new Computadora(cliente1.PetisionesDePc.Sofware, cliente1.PetisionesDePc.Periféricos, cliente1.PetisionesDePc.Juegos);


            // Console.WriteLine(c1==c2);
            //Console.WriteLine(aux.Mostrar());

            // Local.GuardarCompuEnListaCompusDisponibles(local1, c1);


            //_ = local1 + c1;             
            //_ = local1 + c2;
            //_ = local1 + c3;
            //_ = local1 + c4;
            //_ = local1 + c5;
            //_ = local1 + c6;
            //_ = local1 + c7;
            //_ = local1 + c8;
            //_ = local1 + c9;
            //_ = local1 + c10;
            //_ = local1 + c11;
            //_ = local1 + c12;
            //_ = local1 + c13;
            //_ = local1 + c14;
            //_ = local1 + c15;

            //_ = local1 + cab1;
            //_ = local1 + cab2;
            //_ = local1 + cab3;

            // Console.WriteLine(local1.MostrarCompusYCabinasDelLocal());
            //Console.WriteLine(local1.MostrarCompusDisponibles());

//--------------------------------------------------------------------------------------------------

            //Local.AsignarCabinaAlCliente(local1, cab1);
            //Local.AsignarCabinaAlCliente(local1, cab2);
            //Local.AsignarCabinaAlCliente(local1, cab3);

            //Thread.Sleep(4000);
            //Local.FinalizarTareaCabina(local1, cab1);//4seg = 4$
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCabina(local1, cab2);//8seg =(8*2.5)
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCabina(local1, cab3);//12seg =(12*5)

            //Console.WriteLine(local1.MostrarCabinasDisponibles());
            //Console.WriteLine();
            //Console.WriteLine(local1.MostrarCabinasOcupadas());

            //Console.WriteLine(local1.Horas_totales_Y_La_Recaudación_Por_Tipo_De_Llamada());
            //Console.WriteLine(local1.ListaCabinasOrdenadasPorTiempoDeUso(local1));



            //------------------------------------------------------------------------------------------------------
            //Console.WriteLine(local1.BuscarCompuEnLaLista(aux));
            //Console.WriteLine(local1.MostrarCompusDisponiblesParaElClienteSegunsSusPetisiones(aux));
            //Console.WriteLine();
            ////Local.EliminarCompuEnListaCompusDisponibles(local1, c5);
            //Local.AsignarCompuAlCliente(local1, c3);
            //Console.WriteLine();
            ////Console.WriteLine(local1==c1);
            //Console.WriteLine();
            //Console.WriteLine(local1.MostrarCompusDisponibles());
            //Console.WriteLine();
            //Console.WriteLine(local1.MostrarCompusOcupadas());

            //Local.FinalizarTareaCompu(local1, c3);
            //Console.WriteLine();
            //Console.WriteLine(local1.MostrarCompusDisponibles());
            //Console.WriteLine();




            //--------------------------------------------------------------------------------------------------------------

            //Local.AsignarCompuAlCliente(local1, c3);
            //Local.AsignarCompuAlCliente(local1, c4);
            //Local.AsignarCompuAlCliente(local1, c5);
            //Local.AsignarCompuAlCliente(local1, c6);
            //Local.AsignarCompuAlCliente(local1, c7);
            //Local.AsignarCompuAlCliente(local1, c8);
            //Local.AsignarCompuAlCliente(local1, c9);
            //Local.AsignarCompuAlCliente(local1, c10);

            //Local.FinalizarTareaCompu(local1, c3);

            //Local.AsignarCompuAlCliente(local1, c3);

            //Console.WriteLine(local1.PetisionesMasPedidas());

            //------------------------------------------------------------------------------------------------------------------
            //Local.AsignarCompuAlCliente(local1, c3);
            //Local.AsignarCompuAlCliente(local1, c4);
            //Local.AsignarCompuAlCliente(local1, c5);
            //Local.AsignarCompuAlCliente(local1, c6);
            //Local.AsignarCompuAlCliente(local1, c7);
            //Local.AsignarCompuAlCliente(local1, c8);
            //Local.AsignarCompuAlCliente(local1, c9);
            //Local.AsignarCompuAlCliente(local1, c10);

            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c3);//4seg
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c4);//8seg
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c5);//12seg
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c6);//16seg
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c7);//20seg
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c8);//24seg
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c9);//28seg
            //Thread.Sleep(4000);
            //Local.FinalizarTareaCompu(local1, c10);//32seg


            //Console.WriteLine(local1.GananciasTotales());//4.5
            //Console.WriteLine(local1.ListaPcOrdenadasPorTiempoDeUso(local1));
            //-----------------------------------------------------------------------------------------------


        }
    }
}
