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

		// **********
		[System.ComponentModel.DisplayName(displayName: "نام")]
		public string Name { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "تاریخ")]
		public string Date { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "اولین")]
		public decimal First { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "بالاترین")]
		public decimal High { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "پایین‌ترین")]
		public decimal Low { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "پایانی")]
		public decimal Close { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "قیمت")]
		public decimal Value { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "حجم")]
		public decimal Volume { get; set; }
		// **********

		// **********
		public decimal OpenInt { get; set; }
		// **********

		// **********
		public string Per { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "باز")]
		public decimal Open { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName(displayName: "آخرین")]
		public decimal Last { get; set; }
		// **********
	}
}
