using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EZMetrology.Channels.Bluetooth
{
    public struct BluetoothAddress
    {
        /// <summary>
        /// 
        /// </summary>
        public Int16 Nap
        {
            get { return BitConverter.ToInt16(rawAddress, 0); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Byte Uap
        {
            get { return rawAddress[2]; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int24 Lap
        {
            get { return Int24.FromBytes(rawAddress, 3); }
        }

        private BluetoothAddress(Byte[] rawAddress)
        {
            this.rawAddress = rawAddress;
        }

        public static BluetoothAddress FromBytes(IEnumerable<Byte> address)
        {
            return new BluetoothAddress(address.ToArray());
        }

        //public static BluetoothAddress FromUInt48(UInt48 rawAddress)
        //{

        //}

        public static BluetoothAddress FromInt64(Int64 address)
        {
            return new BluetoothAddress(BitConverter.GetBytes(address));
        }

        [CLSCompliant(false)]
        public static BluetoothAddress FromUInt64(UInt64 address)
        {
            return new BluetoothAddress(BitConverter.GetBytes(address));
        }

        public static BluetoothAddress Parse(String address)
        {
            return new BluetoothAddress(address
                .Split(':')
                .Select(s => Byte.Parse(s, NumberStyles.HexNumber))
                .ToArray());
        }

        public Int64 ToInt64()
        {
            return BitConverter.ToInt64(rawAddress, 0);
        }

        public Byte[] ToByteArray()
        {
            return rawAddress;
        }

        public override String ToString()
        {
            return rawAddress
                .Skip(1)
                .Aggregate(
                    rawAddress.FirstOrDefault().ToString("X").PadLeft(2, '0'), 
                    (address, val) => 
                        String.Format("{0}:{1}", address, val.ToString("X").PadLeft(2, '0')));
        }

        private Byte[] rawAddress;
    }
}
