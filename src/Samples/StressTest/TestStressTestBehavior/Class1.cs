﻿using HolyClient.Abstractions.StressTest;
using System.Reactive.Disposables;

namespace TestStressTestBehavior
{
	public class Class1 : IStressTestBehavior
	{
		public Task Activate(CompositeDisposable disposables, IEnumerable<IStressTestBot> bots, CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}
	}
}
