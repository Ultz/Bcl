﻿using Ultz.Extensions.Commands.ModuleBases;
using Ultz.Extensions.Commands.Parsing.ArgumentParsers;

namespace Ultz.Extensions.Commands.Results.Failed.Execution
{
    /// <summary>
    /// Represents the execution step at which the <see cref="ExecutionFailedResult" /> was returned.
    /// </summary>
    public enum CommandExecutionStep
    {
        /// <summary>
        /// An exception occurred while handling the <see cref="Built.Command" />'s checks.
        /// </summary>
        Checks,

        /// <summary>
        /// An exception occurred in <see cref="IArgumentParser.ParseAsync" /> during raw argument parsing.
        /// </summary>
        ArgumentParsing,

        /// <summary>
        /// An exception occurred during type parsing.
        /// </summary>
        TypeParsing,

        /// <summary>
        /// An exception occurred during generating the cooldown bucket key using
        /// <see cref="CommandService.CooldownBucketKeyGenerator" />.
        /// </summary>
        CooldownBucketKeyGenerating,

        /// <summary>
        /// An exception occcured in <see cref="ModuleBase{TContext}.BeforeExecutedAsync" />.
        /// </summary>
        BeforeExecuted,

        /// <summary>
        /// An execution occurred when executing the <see cref="Built.Command" />.
        /// </summary>
        Command
    }
}