using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;

namespace Consultorio.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        Task<IEnumerable<PacienteDto>> GetPacientesAsync();
        Task<Paciente> GetPacienteByIdAsync(int id);
        //Task<Paciente> GetPacientesByIdAsync(int id);
    }
}
