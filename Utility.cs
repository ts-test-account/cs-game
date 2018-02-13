using System;
using System.Security.Cryptography;

namespace ConsoleGame{

	static public class Utility{
		
		//一様乱数（0〜1）
		public static double GetRandom(){
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] bs = new byte[sizeof(UInt32)];
			rng.GetBytes(bs);
			UInt32 iR = System.BitConverter.ToUInt32(bs, 0);
			return ((double)iR / UInt32.MaxValue);
		}
	}

}
