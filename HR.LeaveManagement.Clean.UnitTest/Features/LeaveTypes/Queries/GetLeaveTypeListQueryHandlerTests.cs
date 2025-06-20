using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.MappingProfiles;
using HR.LeaveManagement.UnitTest.Mocks;
using AutoMapper;
using Moq;
using Shouldly;

namespace HR.LeaveManagement.Application.UnitTests.Features.LeaveTypes.Queries
{
    public class GetLeaveTypeListQueryHandlerTests
    {
        private readonly Mock<ILeaveTypeRepository> _mockRepo;
        private IMapper _mapper;
        private Mock<IAppLogger<GetAllLeaveTypesQueryHandler>> _mockAppLogger;

        public GetLeaveTypeListQueryHandlerTests()
        {
            _mockRepo = MockLeaveTypeRepository.GetMockLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<LeaveTypeProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            _mockAppLogger = new Mock<IAppLogger<GetAllLeaveTypesQueryHandler>>();
        }

        [Fact]
        public async Task GetLeaveTypeListTest()
        {
            var handler = new GetAllLeaveTypesQueryHandler(_mapper, _mockRepo.Object, _mockAppLogger.Object);

            var result = await handler.Handle(new GetAllLeaveTypesQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<LeaveTypeDto>>();
            result.Count.ShouldBe(3);
        }
    }
}
