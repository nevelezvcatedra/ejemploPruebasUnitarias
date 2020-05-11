using System;

namespace LogicaNegocio
{
    public class Envio
    {

        public static int calcularValorEnvio(int pesoPaqueteKg, int distanciaEntregaKm, bool esPrioritario)
        {
            int precioEnvio = 0, precioPorKgEnvio = 0;

            if(distanciaEntregaKm < 100){
                if (esPrioritario)
                {
                    precioPorKgEnvio = 3200;
                }
                else
                {
                    precioPorKgEnvio = 2500;
                }
            }
            else if(distanciaEntregaKm < 500)
            {
                if (esPrioritario)
                {
                    precioPorKgEnvio = 5000;
                }
                else
                {
                    precioPorKgEnvio = 4500;
                }
            }
            else if (distanciaEntregaKm < 800)
            {
                if (esPrioritario)
                {
                    precioPorKgEnvio = 6000;
                }
                else
                {
                    precioPorKgEnvio = 5450;
                }
            }
            else
            {
                if (esPrioritario)
                {
                    precioPorKgEnvio = 10000;
                }
                else
                {
                    precioPorKgEnvio = 7500;
                }
            }

            precioEnvio = precioPorKgEnvio * pesoPaqueteKg;

            return precioEnvio;
        }

    }
}
