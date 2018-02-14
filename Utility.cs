using System;
using System.Security.Cryptography;

namespace ConsoleGame{
		static public class Utility{

				//乱数の取得
				private static UInt32 GetRandom(){
					RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
					byte[] bs = new byte[sizeof(UInt32)];
					rng.GetBytes(bs);
					return System.BitConverter.ToUInt32(bs, 0);
				}
				
				//一様乱数（0〜1）を取得
				public static double GetRandom01(){
					return ((double)GetRandom() / UInt32.MaxValue);
				}

				//指定範囲の整数の一様乱数を取得
				public static int GetSelectedRandom(int min, int max)
				{
					return (int)((GetRandom() % max) + min);
				}
		}
}
