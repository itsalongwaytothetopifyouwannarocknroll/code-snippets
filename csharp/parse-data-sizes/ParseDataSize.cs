	public static class Helper
	{
		public static long ParseDataSize(int @base, string size)
		{
			string[] JedecNotationSizes = { "BYTES", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
			string[] IecNotationSizes = { "BYTES", "KIB", "MIB", "GIB", "TIB", "PIB", "EIB", "ZIB", "YIB" };

			string _exMessage = "Invalid format for DataSize type: {0}";
			string _trimedSize = size.Trim();

			//empty string = 0 bytes
			if (_trimedSize.Length == 0)
			{
				return (long)0;
			}

			// default is bytes
			// number without suffix is bytes
			if (long.TryParse(size, out long _result))
			{
				return _result;
			}

			// Return the result.

			if (ParseSize(@base, _trimedSize.ToUpper(), JedecNotationSizes, out _result) || 
				(ParseSize(@base, _trimedSize.ToUpper(), IecNotationSizes, out _result)))
			{
				return _result;
			} else
			{
				throw new FormatException(String.Format(_exMessage, _trimedSize));
			}

		}

		public static long ParseDataSize(string size)
		{
			return ParseDataSize(1024, size);
		}

		private static bool ParseSize(int @base, string trimedString, string[] notation, out long size)
		{
			double _number = 0;
			int _notationIndex = -1;
			for (int i = 0; i < notation.Length; i++)
			{
				if ((trimedString.Length > notation[i].Length) && 
					(trimedString.Substring(trimedString.Length - notation[i].Length) == notation[i]))
				{
					_notationIndex = i;
					_number = double.Parse(trimedString.Substring(0, trimedString.Length - notation[i].Length));
					break;
				}
			}
			if (_notationIndex >= 0)
			{
				size = (long)Math.Round(_number * Math.Pow(@base, _notationIndex));
				return true;
			} else
			{
				size = 0;
				return false;
			}
		}
	}