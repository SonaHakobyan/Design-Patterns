using System;

namespace Command
{
    /// <summary>
    /// Define the ITransaction interface
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Transaction id
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Transaction status
        /// </summary>
        State Status { get; set; }

        /// <summary>
        /// Execute the command
        /// </summary>
        void Execute();

        /// <summary>
        /// Undo the command
        /// </summary>
        void Undo();
    }
}
