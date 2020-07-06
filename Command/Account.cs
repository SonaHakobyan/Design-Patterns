namespace Command
{
    /// <summary>
    /// Bank account class
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Account owner
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Account balance
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Create a new instance of Account
        /// </summary>
        /// <param name="owner">The owner</param>
        /// <param name="balance">The balance</param>
        public Account(string owner, decimal balance)
        {
            this.Owner = owner;
            this.Balance = balance;
        }
    }
}
