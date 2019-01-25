using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
        int defaultamount = 1000, deposit, withdrawl;
        int option;
        double pin;
        string name;
        string location;
        bool balancecheck;
        char ch=' ';
        Console.WriteLine("Enter Your First and Last name: "); 
        name = Console.ReadLine();
        Console.WriteLine("Enter the location:");
        location=Console.ReadLine();
        Console.WriteLine("Enter Your 4 Digit PIN Number:");
        pin = double.Parse(Console.ReadLine());
        while (true)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("*********** Welcome to the ATM Service **************\n");
            Console.WriteLine("1. Check Balance\n");
            Console.WriteLine("2. Withdrawl Cash\n");
            Console.WriteLine("3. Deposit Cash\n");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("5. FeedBack\n");
            Console.WriteLine("*********************************************\n\n");
            Console.WriteLine("Enter your choice: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
            case 1:
            balancecheck=true;
                Console.WriteLine("\n YOUR BALANCE IN Rs : {0} ", defaultamount);
                
                break;
            case 2:
                Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                withdrawl = int.Parse(Console.ReadLine())   ;
                
                if (withdrawl % 100 != 0)
                {
                    Console.WriteLine("\n PLEASE ENTER THE WITHDRAWL AMOUNT IN THE MULTIPLES OF 100 ONLY.");
                }
                else if (withdrawl > (defaultamount - 500))
                {
                    Console.WriteLine("\n YOU'VE INSUFFICENT BALANCE IN YOUR ACCOUNT");
                }
                else
                {
                    withdrawl=withdrawl+AreaCharges(location);
                    defaultamount = defaultamount - withdrawl;
                    Console.WriteLine("\n\n PLEASE COLLECT CASH");
                    Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", defaultamount);
                }
                break;
            case 3:
                Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT INTO YOUR ACCOUNT");
                deposit = int.Parse(Console.ReadLine());
                defaultamount = defaultamount + deposit;
                Console.WriteLine("YOUR BALANCE IS {0}", defaultamount);
                break;
            case 4:
                Console.WriteLine("\n THANK U FOR USING ATM");
                break;
                
            case 5:
                Console.WriteLine("Please Enter (Y) if you're satisfied with the service \n and (N) if you're not satisfied with the service.");
                string str=Console.ReadLine();
                ch = str[0];
                if(ch=='y'){
                    Console.WriteLine("\n Thanks for the feedback, we appreciate you.");
                }
                else{
                    Console.WriteLine("\n Thanks for the feedback, we apologize for the service we caused.");
                }
                break;
            default:
                Console.WriteLine("\n\n THANKS FOR USING OUR ATM SERVICE");
                break;
            }
            
        }
       
    }
      
        public static int AreaCharges(String location){
             decimal  transcharges;
             if(location=="maryville"){
          transcharges=0;
             }
             else{
               transcharges=10m;
             }
             return Convert.ToInt32(transcharges);
         }  
          
       
    
}
}
