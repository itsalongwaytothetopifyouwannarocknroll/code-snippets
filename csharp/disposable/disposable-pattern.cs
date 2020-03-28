class TestClass: IDisposable
{

	#region IDisposable pattern
	private bool _disposed = false;

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			if (disposing)
			{
				// Dispose any managed objects
				__Parent.RemoveSandbox(this);
			}

			// Now disposed of any unmanaged objects
			// ...

			_disposed = true;
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	// Destructor
	~TestClass()
	{
		Dispose(false);
	}
	#endregion
}