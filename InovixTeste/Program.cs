﻿using Inovix.Data;
using InovixTeste.KGBAccountCustomer;
using InovixTeste.KGBCustomer;
using InovixTeste.KGBFinanceiro;


namespace InovixTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerWebServiceSoapClient();

            var financeiroService = new FinanceiroClient();

            var accountCustomerClient = new AccountCustomerClient();
            
            var customer = customerService.GetCustomerByCpf("322.391.544-38");
             
            var finaceiro = financeiroService.ObterStatusFinanceiroCliente("322.391.544-38");            

        }
    }
}
