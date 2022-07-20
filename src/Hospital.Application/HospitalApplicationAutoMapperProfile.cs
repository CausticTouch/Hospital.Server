using AutoMapper;
using Hospital.Appointments;
using Hospital.Documents;
using Hospital.User;
using Hospital.Usrs;

namespace Hospital;

public class HospitalApplicationAutoMapperProfile : Profile
{
    public HospitalApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Appointment, AppointmentDto>();
        CreateMap<CreateAppointmentDto, Appointment>();
        CreateMap<UpdateAppointmentDto, Appointment>();

        CreateMap<Document, DocumentDto>();
        CreateMap<CreateDocumentDto, Document>();
        CreateMap<UpdateDocumentDto, Document>();

        CreateMap<Usr, UsrDto>();
        CreateMap<CreateUsrDto, Usr>();
        CreateMap<UpdateUsrDto, Usr>();
    }
}
