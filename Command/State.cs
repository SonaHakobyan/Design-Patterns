namespace Command
{
    /// <summary>
    /// Define an enumeration of command status
    /// </summary>
    public enum State
    {
        /// <summary>
        /// Unprocessed command
        /// </summary>
        Unprocessed,

        /// <summary>
        /// Execution failed
        /// </summary>
        ExecuteFailed,

        /// <summary>
        /// Execution succeeded
        /// </summary>
        ExecuteSucceeded,

        /// <summary>
        /// Undo failed
        /// </summary>
        UndoFailed,

        /// <summary>
        /// Undo succeeded
        /// </summary>
        UndoSucceeded
    }
}
