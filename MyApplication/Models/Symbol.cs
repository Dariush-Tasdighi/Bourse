namespace Models
{
	public class Symbol : object
	{
		public Symbol() : base()
		{
		}

		public Symbol(string data) : base()
		{
			if (string.IsNullOrWhiteSpace(data))
			{
				return;
			}

			string[] items = data.Split(',');

			Name = items[0];
			Date = items[1];
			First = System.Convert.ToDecimal(items[2]);
			High = System.Convert.ToDecimal(items[3]);
			Low = System.Convert.ToDecimal(items[4]);
			Close = System.Convert.ToDecimal(items[5]);
			Value = System.Convert.ToDecimal(items[6]);
			Volume = System.Convert.ToDecimal(items[7]);
			OpenInt = System.Convert.ToDecimal(items[8]);
			Per = items[9];
			Open = System.Convert.ToDecimal(items[10]);
			Last = System.Convert.ToDecimal(items[11]);
		}

		public string Name { get; set; }

		public string Date { get; set; }

		public decimal First { get; set; }

		public decimal High { get; set; }

		public decimal Low { get; set; }

		public decimal Close { get; set; }

		public decimal Value { get; set; }

		public decimal Volume { get; set; }

		public decimal OpenInt { get; set; }

		public string Per { get; set; }

		public decimal Open { get; set; }

		public decimal Last { get; set; }
	}
}
