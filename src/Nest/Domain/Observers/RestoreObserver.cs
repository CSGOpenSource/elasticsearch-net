using System;

namespace Nest_1_7_2
{
	public class RestoreObserver : CoordinatedRequestObserver<IRecoveryStatusResponse>
	{
		public RestoreObserver(
			Action<IRecoveryStatusResponse> onNext = null, 
			Action<Exception> onError = null,
			Action completed = null)
			: base(onNext, onError, completed)
		{
			
		}
	}
}