using SegurosFalabellaEntity;
using System.Collections.Generic;
using System.ServiceModel;

namespace SegurosFalabellaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISaleWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISaleWCF
    {
        [OperationContract]
        List<Sale> SelectSale();

        [OperationContract]
        List<Customer> SelectCustomer();

        [OperationContract]
        Sale SelectSaleId(int id);

        [OperationContract]
        void AddSale(Sale Obejto);

        [OperationContract]
        void AddSaleCustomer(Sale Obejto);
    }
}
