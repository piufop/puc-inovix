﻿using System.ServiceModel;

namespace KGBWebService.Wcf
{
    [ServiceContract]
    public interface IFinanceiro
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int ObterStatusFinanceiroCliente(string cpf);
    }
}
