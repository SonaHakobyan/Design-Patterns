using System;

namespace Command.Transactions
{
    /// <summary>
    /// Reversible dposit transaction
    /// </summary>
    public class Deposit : ITransaction
    {
        /// <summary>
        /// The amount
        /// </summary>
        private readonly decimal amount;

        /// <summary>
        /// Owner's account
        /// </summary>
        private readonly Account account;

        /// <summary>
        /// Transaction id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Transaction status
        /// </summary>
        public State Status { get; set; }

        /// <summary>
        /// Creates a new instance of Deposit
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <param name="account"></param>
        public Deposit(int id, decimal amount, Account account)
        {
            this.Id = id;
            this.amount = amount;
            this.account = account;

            this.CreatedOn = DateTime.UtcNow;
            this.Status = State.Unprocessed;
        }

        /// <summary>
        /// Execute the deposit transaction
        /// </summary>
        public void Execute()
        {
            // add amount to the balance
            this.account.Balance += this.amount;

            // set as succeeded
            this.Status = State.ExecuteSucceeded;
        }

        /// <summary>
        /// Undo the deposit transaction
        /// </summary>
        public void Undo()
        {
            // if not enough
            if (this.account.Balance < this.amount)
            {
                // set as failed
                this.Status = State.UndoFailed;
                return;
            }

            // get amount back
            this.account.Balance -= this.amount;

            // set as succeeded
            this.Status = State.UndoSucceeded;
        }
    }
}
