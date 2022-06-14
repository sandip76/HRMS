using AutoMapper;
using EMS.BLL.ModelBll;
using EMS.DLL.DataModels;

namespace EMS.BLL.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            _registerMapping();
        }
        private void _registerMapping()
        {
            CreateMap<EmployeeModelBll, Employee>().ReverseMap();


            //CreateMap<API.Model.Wrapper.ResponseApi, BLL.Model.HelperBll.ResponseBll>().ReverseMap();

            //CreateMap<API.Model.BaseClass, BLL.Model.BaseClass>().ReverseMap();
            //CreateMap<BLL.Model.BaseClass, DAL.Model.BaseClass>().ReverseMap();

            //CreateMap<BLL.Model.Contact, DAL.Model.Contact>().ReverseMap();
        }
    }
}
