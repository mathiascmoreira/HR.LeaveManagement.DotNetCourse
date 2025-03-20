using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

//public class GetAllLeaveTypesQuery: IRequest<List<LeaveTypeDto>>
//{
//}

public record GetAllLeaveTypesQuery : IRequest<List<LeaveTypeDto>>; //It´s recommended to use a record instead of a class
