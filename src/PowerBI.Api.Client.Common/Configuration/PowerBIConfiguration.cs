﻿namespace PowerBI.Api.Client.Configuration
{
	/// <summary>
	/// PowerBI configuration.
	/// </summary>
	sealed class PowerBISimpleConfiguration : IPowerBIConfiguration
	{
		/// <summary>
		/// PowerBI Api url
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// OAuth authority
		/// </summary>
		public string Authority { get; set; }

		/// <summary>
		/// Resource for the token
		/// </summary>
		public string Resource { get; set; }

		/// <summary>
		/// ClientId for the token
		/// </summary>
		public string Client { get; set; }

		/// <summary>
		/// User
		/// </summary>
		public string User { get; set; }

		/// <summary>
		/// Password
		/// </summary>
		public string Password { get; set; }
	}
}

