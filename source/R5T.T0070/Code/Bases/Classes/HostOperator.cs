using System;


namespace R5T.T0070
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class HostOperator : IHostOperator
    {
        #region Static
        
        public static HostOperator Instance { get; } = new();

        #endregion
    }
}