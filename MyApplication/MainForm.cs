//using System.Linq;

namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm() : base()
		{
			InitializeComponent();
		}

		public string RootPath { get; set; }

		public string RemoteUri { get; set; }

		public string RemoteDownloadUri { get; set; }

		public System.Windows.Forms.WebBrowser MyWebBrowser { get; set; }

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			RemoteUri =
				"http://www.tsetmc.com/Loader.aspx?";

			RemoteDownloadUri =
				"http://www.tsetmc.com/tsev2/data/Export-txt.aspx?";
		}

		public static byte[] DecompressGZip(byte[] bytesToDecompress)
		{
			using (System.IO.Compression.GZipStream stream = new System.IO.Compression.GZipStream
				(new System.IO.MemoryStream(bytesToDecompress), System.IO.Compression.CompressionMode.Decompress))
			{
				const int size = 4096;
				byte[] buffer = new byte[size];

				using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
				{
					int count;

					do
					{
						count = stream.Read(buffer, 0, size);

						if (count > 0)
						{
							memoryStream.Write(buffer, 0, count);
						}
					} while (count > 0);

					return memoryStream.ToArray();
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Net.WebClient webClient = null;

			try
			{
				string id =
					"33603212156438463";

				string remotePathName =
					$"{ RemoteDownloadUri }t=i&a=1&b=0&i={ id }";


				// **************************************************
				webClient =
					new System.Net.WebClient();

				webClient.Encoding = System.Text.Encoding.UTF8;

				byte[] result =
					webClient.DownloadData(address: remotePathName);

				byte[] decompressedResult = DecompressGZip(result);

				contentTextBox.Text =
					System.Text.Encoding.UTF8.GetString(decompressedResult);
				// **************************************************

				// **************************************************
				string temp =
					contentTextBox.Text.Replace("\r", string.Empty);

				System.Collections.Generic.List<Models.Symbol>
					symbols = new System.Collections.Generic.List<Models.Symbol>();

				string[] rows =
					contentTextBox.Text.Split('\n');

				for (int index = 1; index <= rows.Length - 1; index++)
				{
					Models.Symbol symbol = new Models.Symbol(rows[index]);

					symbols.Add(symbol);
				}
				// **************************************************

				myDataGridView.DataSource = symbols;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (webClient != null)
				{
					webClient.Dispose();
					//webClient = null;
				}
			}
		}
	}
}
