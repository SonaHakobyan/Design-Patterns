using Command.Transactions;

namespace Command
{
    class Program
    {
        public object Assert { get; private set; }

        static void Main(string[] args)
        {
            var transactionManager = new TransactionManager();

            var spendings = new Account("Mike", 0);
            var savings = new Account("Mike", 100);

            transactionManager.AddTransaction(new Deposit(1, 100, spendings));
            transactionManager.AddTransaction(new Withdraw(2, 25, spendings));
            transactionManager.AddTransaction(new Transfer(3, 30, spendings, savings));

            transactionManager.ProcessPendingTransactions();

            transactionManager.UndoTransaction(2);

            transactionManager.AddTransaction(new Withdraw(4, 100, spendings));
            transactionManager.ProcessPendingTransactions();
        }
    }
}