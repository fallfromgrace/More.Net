namespace More.Net.Media.Riff.Wave
{
    /// <summary>
    /// 
    /// </summary>
    internal enum AudioFormat : ushort
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown = 0x0000,

        /// <summary>
        /// 
        /// </summary>
        PCM = 0x0001,

        /// <summary>
        /// /
        /// </summary>
        MicrosoftADPCM = 0x0002,

        /// <summary>
        /// 
        /// </summary>
        ALaw = 0x0006,

        /// <summary>
        /// 
        /// </summary>
        MuLaw = 0x0007,

        /// <summary>
        /// 
        /// </summary>
        Experimental = 0xFFFF
    }
}
