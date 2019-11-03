﻿using Hangfire.Annotations;
using Hangfire.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspEfCore.Web.Jobs
{
    public class CustomBackgroundJobStateChanger : IBackgroundJobStateChanger
    {
        private readonly IBackgroundJobStateChanger _inner;

        public CustomBackgroundJobStateChanger([NotNull] IBackgroundJobStateChanger inner)
        {
            _inner = inner ?? throw new ArgumentNullException(nameof(inner));
        }

        public IState ChangeState(StateChangeContext context)
        {
            Console.WriteLine($"ChangeState {context.BackgroundJobId} to {context.NewState}");
            return _inner.ChangeState(context);
        }
    }
}