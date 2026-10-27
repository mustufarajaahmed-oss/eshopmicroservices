using MediatR;

namespace BuildingBlocks.CQRS
{
    /// <summary>
    /// If we do not need any response
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public interface ICommandHandler<in TCommand> 
        : ICommandHandler<TCommand, Unit>
        where TCommand: ICommand<Unit>
    { 
    }

    /// <summary>
    /// If we need any response
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public interface ICommandHandler<in TCommand, TResponse> 
        : IRequestHandler<TCommand, TResponse>
        where TCommand: ICommand<TResponse>
        where TResponse : notnull
    {
    }
}
