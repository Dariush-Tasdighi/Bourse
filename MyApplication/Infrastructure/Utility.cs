namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
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
	}
}
