using System;


namespace R5T.T0070
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Host : IHost
    {
        #region Static
        
        public static Host Instance { get; } = new();

        #endregion
    }
}