using System;

namespace PSCDPackPlus.PSCDLib.Enums
{
    /// <summary>
    /// Represents game cartridge region.
    /// </summary>
    public enum ROMRegion
    {
        /// <summary>
        /// The cartridge is for USA (NTSC/English).
        /// </summary>
		Usa,
        /// <summary>
        /// The cartridge is for Japan (NTSC/Japanese).
        /// </summary>
		Japan,
        /// <summary>
        /// The cartridge is for Europe (PAL/English).
        /// </summary>
		Europe,
        /// <summary>
        /// The cartridge supports all NTSC/PAL and language combinations.
        /// </summary>
		Worldwide // Default region in emulator, acts as Usa
    }
}
