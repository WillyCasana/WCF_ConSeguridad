using System.ServiceModel;

namespace WebApplication2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITestService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        long AVeryBS(long[] ar);
    }
}
