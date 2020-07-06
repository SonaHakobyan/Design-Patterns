using System;

namespace Command.Transactions
{
    /// <summary>
    /// Reversible withdraw transaction
    /// </summary>
    public class Withdraw : ITransaction
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
        /// Creates a new instance of Withdraw transaction
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <param name="account"></param>
        public Withdraw(int id, decimal amount, Account account)
        {
            this.Id = id;
            this.account = account;
            this.amount = amount;

            this.CreatedOn = DateTime.UtcNow;
            this.Status = State.Unprocessed;
        }

        /// <summary>
        /// Execute the withdraw transaction
        /// </summary>
        public void Execute()
        {
            // if not enough
            if (this.account.Balance < this.amount)
            {
                // set as failed
                this.Status = State.ExecuteFailed;
                return;
            }

            // withdraw the amount
            this.account.Balance -= this.amount;

            // set as succeeded
            this.Status = State.ExecuteSucceeded;
        }

        /// <summary>
        /// Undo the withdraw transaction
        /// </summary>
        public void Undo()
        {
            // transfer the amount back
            this.account.Balance += this.amount;

            // set as succeeded
            this.Status = State.UndoSucceeded;
        }
    }
}
