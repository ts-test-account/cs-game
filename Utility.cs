using System;
using System.Security.Cryptography;

namespace ConsoleGame{

	static public class Utility{
		public static double GetRandom(){
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] bs = new byte[sizeof(Int32)];
			rng.GetBytes(bs);
			int iR = System.BitConverter.ToInt32(bs, 0);
			return ((double)iR / Int32.MaxValue);
		}
	}

}
