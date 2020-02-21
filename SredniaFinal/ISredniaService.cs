using System.ServiceModel;

namespace SredniaFinal
{
    [ServiceContract]
    public interface ISredniaService
    {
        [OperationContract]
        double ObliczSrednia(double[] args);

        [OperationContract]
        string CzyPoprawna(double[] args);

        [OperationContract]
        string CzyZdane(double srednia);
    }
}
