using AutoMapper;
using HarvardUniversity.API.ModelDTOs.CourseDTOs;
using HarvardUniversity.API.ModelDTOs.GroupDTOs;
using HarvardUniversity.API.ModelDTOs.StudentDTOs;
using HarvardUniversity.DataAccessLayer.Models;

namespace HarvardUniversity.API.Properties
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            //Domain <=> DTO
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<CourseCreateDTO, Course>();
            CreateMap<CourseUpdateDTO, Course>();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<GroupCreateDTO, Group>();
            CreateMap<GroupUpdateDTO, Group>();
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<StudentCreateDTO, Student>();
            CreateMap<StudentUpdateDTO, Student>();
        }
    }
}
