using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile: Profile
    {
        public LeaveTypeProfile() 
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveTypeDetailsDto, LeaveType>().ReverseMap();
            //CreateMap<LeaveType, LeaveTypeDetailsDto>(); It really depends on the business logic. If yoy only needs to convert from LeaveType to LeaveTypeDetailsDto you don´t need to use the ReverseMap method.
        }
    }
}
