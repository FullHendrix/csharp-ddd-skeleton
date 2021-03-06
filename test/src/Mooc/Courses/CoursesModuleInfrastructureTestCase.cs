namespace CodelyTv.Test.Mooc.Courses
{
    using CodelyTv.Mooc.Courses.Domain;

    public abstract class CoursesModuleInfrastructureTestCase : MoocContextInfrastructureTestCase
    {
        protected ICourseRepository Repository => GetService<ICourseRepository>();
    }
}