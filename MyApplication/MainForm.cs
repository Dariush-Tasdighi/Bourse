//using System.Linq;

namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm() : base()
		{
			InitializeComponent();
		}

		public string RemoteDownloadUri { get; set; }

		public System.Windows.Forms.WebBrowser MyWebBrowser { get; set; }

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			RemoteDownloadUri =
				"http://www.tsetmc.com/tsev2/data/Export-txt.aspx?";
		}

		private void DownloadFileButton_Click(object sender, System.EventArgs e)
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

				byte[] decompressedResult =
					Infrastructure.Utility.DecompressGZip(result);

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
