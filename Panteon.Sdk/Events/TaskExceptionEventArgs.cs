﻿using System;
using Schyntax;

namespace Panteon.Sdk.Events
{
    public class TaskExceptionEventArgs
    {
        public ScheduledTask Task { get; }
        public Exception Exception { get; }

        public TaskExceptionEventArgs(ScheduledTask scheduledTask, Exception exception)
        {
            Task = scheduledTask;
            Exception = exception;
        }
    }
}