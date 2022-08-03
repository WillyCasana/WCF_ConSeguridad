namespace WebApplication2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TestService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione TestService.svc o TestService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TestService : ITestService
    {
        public long AVeryBS(long[] ar)
        {
            long aVeryBigSum = 0;


            foreach (long i in ar)
            {
                aVeryBigSum += i;
            }

            return aVeryBigSum;
        }
    }
}
