namespace T4Examples.Models
{
    using System;
    using AutoMapper;
    
    public class MappingInitializer {
    	public static void Initialize() {
        	Mapper.CreateMap<Groups, GroupsViewModel>();
        	Mapper.CreateMap<GroupsViewModel, Groups>();
        	Mapper.CreateMap<MonthPoints, MonthPointsViewModel>();
        	Mapper.CreateMap<MonthPointsViewModel, MonthPoints>();
        	Mapper.CreateMap<Users, UsersViewModel>();
        	Mapper.CreateMap<UsersViewModel, Users>();   	
        }
    }
}
