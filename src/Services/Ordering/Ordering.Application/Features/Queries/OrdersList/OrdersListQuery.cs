using MediatR;
using System;
using System.Collections.Generic;

namespace Ordering.Application.Features.Queries.OrdersList
{
    public class OrdersListQuery : IRequest<List<OrdersVm>>
    {
        public string UserName { get; set; }

        public OrdersListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}