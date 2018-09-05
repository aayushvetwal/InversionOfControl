using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UE = UnityExample;
using Microsoft.Practices.Unity;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stage 1
            Stage1.CustomerBusinessLogic customerBL1 = new Stage1.CustomerBusinessLogic();
            string customerName1 = customerBL1.GetCustomerName(1);
            Console.WriteLine(customerName1);

            //Stage 2
            Stage2.CustomerBusinessLogic customerBL2 = new Stage2.CustomerBusinessLogic();
            string customerName2 = customerBL2.GetCustomerName(2);
            Console.WriteLine(customerName2);

            //Stage 3
            Stage3.CustomerBusinessLogic customerBL3 = new Stage3.CustomerBusinessLogic();
            string customerName3 = customerBL3.GetCustomerName(3);
            Console.WriteLine(customerName3);

            //Stage 4
            Stage4.CustomerBusinessLogic customerBL4 = new Stage4.CustomerBusinessLogic(new Stage4.CustomerDataAccess());
            string customerName4 = customerBL4.GetCustomerName(4);
            Console.WriteLine(customerName4);

            //Stage 5
            IUnityContainer container = new UnityContainer();
            //Register
            container.RegisterType<Stage5.ICustomerDataAccess, Stage5.CustomerDataAccess>();
            //Resolve
            Stage5.CustomerBusinessLogic customerBL5 = container.Resolve<Stage5.CustomerBusinessLogic>();
            string customerName5 = customerBL5.GetCustomerName(5);
            Console.WriteLine(customerName5);

            //Unity Example
            //Without Unity
            Console.WriteLine();

            int id1 = 6, id2 = 7;
            UE.PaymentDetails payDetails = new UE.PaymentDetails();

            UE.CustomerBusinessLogic noUnityCustomerBL1 = new UE.CustomerBusinessLogic(
                    new UE.OracleDataAccess(),
                    new UE.PaymentServiceA(new UE.VerificationMethodB()),
                    new UE.EmailService()
                );

            UE.CustomerBusinessLogic noUnityCustomerBL2 = new UE.CustomerBusinessLogic(
                    new UE.OracleDataAccess(),
                    new UE.PaymentServiceA(new UE.VerificationMethodB()),
                    new UE.EmailService()
                );

            Console.WriteLine("For First Customer");
            string custName1 = noUnityCustomerBL1.GetCustomerName(id1);
            noUnityCustomerBL1.Pay(payDetails);
            noUnityCustomerBL1.EmailTransactions(id1);

            

            Console.WriteLine();

            Console.WriteLine("For Second Customer");
            string custName2 = noUnityCustomerBL1.GetCustomerName(id2);
            noUnityCustomerBL2.Pay(payDetails);
            noUnityCustomerBL2.EmailTransactions(id1);

            Console.WriteLine();

            //With Unity

            //Register
            container.RegisterType<UE.ICustomerDataAccess, UE.OracleDataAccess>();
            container.RegisterType<UE.IPaymentService, UE.PaymentServiceA>();
            container.RegisterType<UE.IPaymentVerify, UE.VerificationMethodB>();
            container.RegisterType<UE.IEmailService, UE.EmailService>();

            //Resolve
            UE.CustomerBusinessLogic unityCustomerBL1 = container.Resolve<UE.CustomerBusinessLogic>();
            UE.CustomerBusinessLogic unityCustomerBL2 = container.Resolve<UE.CustomerBusinessLogic>();

            Console.WriteLine("For First Customer");
            custName1 = unityCustomerBL1.GetCustomerName(id1);
            unityCustomerBL1.Pay(payDetails);
            unityCustomerBL1.EmailTransactions(id1);

            Console.WriteLine();

            Console.WriteLine("For Second Customer");
            custName2 = unityCustomerBL2.GetCustomerName(id2);
            unityCustomerBL2.Pay(payDetails);
            unityCustomerBL2.EmailTransactions(id2);
            
        }
    }
}
