using System;

namespace Command.Transactions
{
    /// <summary>
    /// Reversible transfer transaction
    /// </summary>
    public class Transfer : ITransaction
    {
        /// <summary>
        /// The amount
        /// </summary>
        private readonly decimal amount;

        /// <summary>
        /// Sender's account
        /// </summary>
        private readonly Account sender;

        /// <summary>
        /// Receiver's account
        /// </summary>
        private readonly Account receiver;

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
        /// Creates a new instance of Transfer transaction
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        public Transfer(int id, decimal amount, Account sender, Account receiver)
        {
            this.Id = id;
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;

            this.CreatedOn = DateTime.UtcNow;
            this.Status = State.Unprocessed;
        }

        /// <summary>
        /// Execute the transfer transaction
        /// </summary>
        public void Execute()
        {
            // if not enough
            if (this.sender.Balance < this.amount)
            {
                // set as failed
                this.Status = State.ExecuteFailed;
                return;
            }

            // transfer the amount
            this.sender.Balance -= this.amount;
            this.receiver.Balance += this.amount;

            // set as succeeded
            this.Status = State.ExecuteSucceeded;
        }

        /// <summary>
        /// Undo the transfer transaction
        /// </summary>
        public void Undo()
        {
            // if not enough
            if (this.receiver.Balance < this.amount)
            {
                // set as failed
                this.Status = State.UndoFailed;
                return;
            }

            // thransfer the amount back
            this.receiver.Balance -= amount;
            this.sender.Balance += amount;

            // set as succeeded
            this.Status = State.UndoSucceeded;
        }
    }
}
