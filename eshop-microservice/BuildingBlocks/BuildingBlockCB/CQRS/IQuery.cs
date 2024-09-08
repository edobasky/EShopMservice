﻿using MediatR;

namespace BuildingBlockCB.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull
    {
    }
}
