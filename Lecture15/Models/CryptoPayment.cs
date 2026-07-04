using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Models
{
	internal class CryptoPayment : PaymentMethod
	{
		public string WalletAddress { get; set; }
		public CryptoType Type { get; set; }

		public override void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing Crypto Wallet payment for {amount}");
		}
	}


	public enum CryptoType
	{
		Bitcoin,
		Ethereum,
		Litecoin,
		Ripple,
		Dogecoin
	}
}


