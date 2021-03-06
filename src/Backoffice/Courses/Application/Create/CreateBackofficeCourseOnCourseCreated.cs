namespace CodelyTv.Backoffice.Courses.Application.Create
{
    using System.Threading.Tasks;
    using CodelyTv.Shared.Domain.Bus.Event;
    using CodelyTv.Shared.Domain.Courses;

    public class CreateBackofficeCourseOnCourseCreated : IDomainEventSubscriber<CourseCreatedDomainEvent>
    {
        private readonly BackofficeCourseCreator _creator;

        public CreateBackofficeCourseOnCourseCreated(BackofficeCourseCreator creator)
        {
            _creator = creator;
        }
        
        public async Task On(CourseCreatedDomainEvent @event)
        {
            await _creator.Create(@event.AggregateId, @event.Name, @event.Duration);
        }
    }
}