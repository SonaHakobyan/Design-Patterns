using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    /// <summary>
    /// Manage transaction operations
    /// </summary>
    public class TransactionManager
    {
        /// <summary>
        /// The collection of transactions
        /// </summary>
        private readonly List<ITransaction> transactions;

        /// <summary>
        /// Create a new instance of TransactionManager
        /// </summary>
        public TransactionManager()
        {
            this.transactions = new List<ITransaction>();
        }

        /// <summary>
        /// Determine if there is any pending transaction
        /// </summary>
        /// <returns></returns>
        public bool HasPendingTransactions()
        {
            return this.transactions.Any(x =>
                x.Status == State.Unprocessed ||
                x.Status == State.ExecuteFailed ||
                x.Status == State.UndoFailed);
        }

        /// <summary>
        /// Add given transaction to the transactions collection
        /// </summary>
        /// <param name="transaction">The transaction</param>
        public void AddTransaction(ITransaction transaction)
        {
            // safety check
            if (transaction == null)
            {
                return;
            }

            // add to the transactions
            this.transactions.Add(transaction);
        }

        /// <summary>
        /// Process pending transactions
        /// </summary>
        public void ProcessPendingTransactions()
        {
            // execute transactions that are unprocessed, or had a previous failed execution
            foreach (var transaction in this.transactions.Where(x =>
                 x.Status == State.Unprocessed ||
                 x.Status == State.ExecuteFailed))
            {
                transaction.Execute();
            }

            // retry the Undo, for transactions that had a previous failed undo operation
            foreach (var transaction in this.transactions.Where(x =>
                 x.Status == State.UndoFailed))
            {
                transaction.Undo();
            }
        }

        /// <summary>
        /// Undo transaction of given id
        /// </summary>
        /// <param name="id">The id</param>
        public void UndoTransaction(int id)
        {
            // get the Command object that has the passed id
            var transaction = this.transactions.FirstOrDefault(x => x.Id == id);

            // safety null check
            if (transaction == null)
            {
                throw new ArgumentException(string.Format($"There is no transaction number: {id}"));
            }

            // status check
            if (transaction.Status != State.ExecuteSucceeded)
            {
                throw new ArgumentException("Can only undo transactions that have been successfully executed.");
            }

            // we have a valid transaction, so perform the "undo".
            transaction.Undo();

            // remove the transaction, if it was successfully completed.
            if (transaction.Status == State.UndoSucceeded)
            {
                this.transactions.Remove(transaction);
            }
        }

        /// <summary>
        /// Remove old transactions
        /// </summary>
        public void RemoveOldTransactions()
        {
            // Remove transaction that have been Executed, and are more than 15 days old.
            transactions.RemoveAll(x =>
                x.Status == State.ExecuteSucceeded &&
                (DateTime.UtcNow - x.CreatedOn).Days > 15);
        }
    }
}
